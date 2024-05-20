using Microsoft.AspNetCore.Mvc;
using HemSok.Data;
using HemSok.Models;
using HemSok.Constants;
using Microsoft.AspNetCore.Authorization;

/*
 Author: Emil Waara
 */
namespace HemSok.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgencyController : ControllerBase
    {
        private readonly IRepository<Agency> agencyRepository;

        public AgencyController(IRepository<Agency> agencyRepository)
        {
            this.agencyRepository = agencyRepository;
        }

        // GET: api/Agency
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Agency>>> GetAgencies()
        {
            var agencies = await agencyRepository.GetAllAsync();
            return (agencies == null) ? NotFound("Could not find any agencies") : Ok(agencies);
        }

        // GET: api/Agency/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Agency>> GetAgency(int id)
        {
            var agency = await agencyRepository.GetAsync(id);
            return (agency == null) ? NotFound("Could not find any category with that id") : Ok(agency);
        }

        // PUT: api/Agency/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        [Authorize(Roles = UserRoles.SuperAdminAndAdmin)]
        public async Task<IActionResult> PutAgency(Agency agency)
        {
            if(agency == null)
            {
                return BadRequest("No agency to update");
            }

            if (!AgencyExists(agency.Id))
            {
                return NotFound("Could not find the agency");
            }

            try
            {
                agencyRepository.Update(agency);
                await agencyRepository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

            return Ok(agency);
        }

        // POST: api/Agency
        [HttpPost]
        [Authorize(Roles = UserRoles.SuperAdmin)]
        public async Task<ActionResult<Agency>> PostAgency(Agency agency)
        {
            if (agency == null)
            {
                return BadRequest("No agency to post.");
            }

            await agencyRepository.AddAsync(agency);
            await agencyRepository.SaveChangesAsync();

            return CreatedAtAction("GetAgency", new { id = agency.Id }, agency);
        }

        // DELETE: api/Agency/5
        [HttpDelete("{id}")]
        [Authorize(Roles = UserRoles.SuperAdmin)]
        public async Task<IActionResult> DeleteAgency(int id)
        {
            var agency = await agencyRepository.GetAsync(id);

            if (agency == null)
            {
                return NotFound();
            }

            try
            {
                agencyRepository.Delete(agency);
                await agencyRepository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

            return Ok();
        }

        private bool AgencyExists(int id)
        {
            return agencyRepository.Queryable().Any(e => e.Id == id);
        }
    }
}
