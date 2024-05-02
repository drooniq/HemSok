using HemSok.Models;
using HemSok.Models.AccountDTO;
using HemSok.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace HemSok.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<Agent> userManager;
        private readonly ITokenService tokenService;
        private readonly SignInManager<Agent> signinManager;
        public AccountController(UserManager<Agent> userManager, ITokenService tokenService, SignInManager<Agent> signInManager)
        {
            this.userManager = userManager;
            this.tokenService = tokenService;
            this.signinManager = signInManager;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LogInDTO loginDTO)
        {
            if (loginDTO == null) return BadRequest(ModelState);

            var user = await userManager.Users.FirstOrDefaultAsync(s => s.Email == loginDTO.Email.ToLower());
            if (user == null) return Unauthorized("Invalid Email!");

            var result = await signinManager.CheckPasswordSignInAsync(user, loginDTO.Password, false);

            if(!result.Succeeded) return Unauthorized("Email not found and/or wrong password");

            return Ok(new UserDTO
            {
                Email = user.Email,
                Token = tokenService.CreateToken(user)
            }) ;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDTO registerDTO)
        {
            try
            {
                if (registerDTO == null) return BadRequest(ModelState);

                var agent = new Agent()
                {
                    Email = registerDTO.Email,
                    UserName = "User"
                    
                };

                var createdUser = await userManager.CreateAsync(agent, registerDTO.Password);
                if (createdUser.Succeeded)
                {
                    var role = await userManager.AddToRoleAsync(agent, "Agent");
                    if (role.Succeeded)
                    {
                        return Ok("User created");
                    }
                    else
                    {
                        return StatusCode(500, role.Errors);
                    }
                }
                else
                {
                    return StatusCode(500, createdUser.Errors);
                }
            }
            catch (Exception e)
            {

                return StatusCode(500, e);
            }

        }
    }
}
