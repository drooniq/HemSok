using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HemSok.Data;
using HemSok.Models;

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

            if (agencies == null)
            {
                return NotFound();
            }

            return Ok(agencies);
        }

        // GET: api/Agency/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Agency>> GetAgency(int id)
        {
            var agency = await agencyRepository.GetAsync(id);

            if (agency == null)
            {
                return NotFound();
            }

            return Ok(agency);
        }

        // PUT: api/Agency/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAgency(int id, Agency agency)
        {
            if (id != agency.Id)
            {
                return BadRequest();
            }

            //_context.Entry(agency).State = EntityState.Modified;

            try
            {
                agencyRepository.Update(agency);
                await agencyRepository.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgencyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok();
        }

        // POST: api/Agency
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Agency>> PostAgency(Agency agency)
        {
            await agencyRepository.AddAsync(agency);
            await agencyRepository.SaveChangesAsync();

            return CreatedAtAction("GetAgency", new { id = agency.Id }, agency);
        }

        // DELETE: api/Agency/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAgency(int id)
        {
            var agency = await agencyRepository.GetAsync(id);

            if (agency == null)
            {
                return NotFound();
            }

            agencyRepository.Delete(agency);
            await agencyRepository.SaveChangesAsync();

            return Ok();
        }

        private bool AgencyExists(int id)
        {
            return agencyRepository.Queryable().Any(e => e.Id == id);
        }
    }
}
