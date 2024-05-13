using HemSok.Data;
using HemSok.Models;
using HemSok.Models.AccountDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;
/*
 Author: Marcus Karlsson
 */
namespace HemSok.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<Agent> userManager;
        private readonly SignInManager<Agent> signinManager;
        private readonly IConfiguration config;
        private readonly IRepository<Agency> agencyRepository;

        public AccountController(UserManager<Agent> userManager, SignInManager<Agent> signInManager, IConfiguration config, IRepository<Agency> agencyRepository)
        {
            this.userManager = userManager;
            this.signinManager = signInManager;
            this.config = config;
            this.agencyRepository = agencyRepository;
        }

        [HttpPost("login")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Login(LogInDTO loginDTO)
        {
            var user = await userManager.FindByEmailAsync(loginDTO.Email);

            if (user == null || !await userManager.CheckPasswordAsync(user, loginDTO.Password))
                return Unauthorized("Password didnt match.");
            
            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, loginDTO.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            foreach (var role in await userManager.GetRolesAsync(user))
            {
                authClaims.Add(new Claim(ClaimTypes.Role, role));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                config["JWT:SigningKey"] ?? throw new InvalidOperationException("Key not configured")));

            var token = new JwtSecurityToken(
                issuer: config["JWT:Issuer"],
                audience: config["JWT:Audience"],
                expires: DateTime.UtcNow.AddDays(7),
                claims: authClaims,
                signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
                );

            return Ok(new LoginResponse
            {
                JwtToken = new JwtSecurityTokenHandler().WriteToken(token),
                ExpirationDate = token.ValidTo,
                Id = user.Id
            });
        
        }
        [Authorize]
        [HttpPost("register")]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Register([FromBody] RegisterDTO registerDTO)
        {
            var existingUser = await userManager.FindByEmailAsync(registerDTO.Email);

            if (existingUser != null) return Conflict("User already exists");           

            var newUser = new Agent()
            {
                Email = registerDTO.Email,               
                UserName = $"{registerDTO.Firstname}{registerDTO.Lastname}",
                FirstName = registerDTO.Firstname,
                LastName = registerDTO.Lastname
            };

            if (registerDTO.agency != null)
                newUser.Agency = await agencyRepository.GetAsync(int.Parse(registerDTO.agency));            

            var result = await userManager.CreateAsync(newUser, registerDTO.Password);

            if (result.Succeeded)
            {
                var role = await userManager.AddToRoleAsync(newUser, "Agent");

                if (role.Succeeded)               
                    return Ok("New user created");
                else
                    return StatusCode(StatusCodes.Status500InternalServerError,
                $"Failed to create user: {string.Join(" ", result.Errors.Select(s => s.Description))}");
            }
            else
                return StatusCode(StatusCodes.Status500InternalServerError,
                $"Failed to create user: {string.Join(" ", result.Errors.Select(s => s.Description))}");
        
        }
    }
}
