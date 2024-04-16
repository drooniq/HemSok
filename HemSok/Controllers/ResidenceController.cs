using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HemSok.Data;
using HemSok.Models;
using Microsoft.AspNetCore.Http.HttpResults;

/*
 Author: Marcus Karlsson
 */
namespace HemSok.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResidenceController : ControllerBase
    {
        private readonly IRepository<Residence> residenceRepo;

        public ResidenceController(IRepository<Residence> residenceRepo)
        {        
            this.residenceRepo = residenceRepo;
        }

        // GET: api/Residence
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Residence>>> GetResidences()
        {
            var residencies = residenceRepo.Queryable()
                .Include(s => s.Municipality)
                .ThenInclude(s => s.County)
                .Include(s => s.Agent)
                .ThenInclude(s => s.Agency)
                .Include(s => s.Category);
            if (residencies == null)
            {
                return NotFound();
            }
            return Ok(residencies);
        }

        // GET: api/Residence/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Residence>> GetResidence(int id)
        {
            var residence = residenceRepo.Queryable()
                .Include(s => s.Municipality)
                .ThenInclude(s => s.County)
                .Include(s => s.Agent)
                .ThenInclude(s => s.Agency)
                .Include(s => s.Category)                         
                .Where(s => s.Id == id);
            if (residence == null)
            {
                return NotFound();
            }

            return Ok(residence);
        }

        // PUT: api/Residence/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResidence(int id, Residence residence)
        {
            if (id != residence.Id)
            {
                return BadRequest();
            }        
            try
            {
                //var residence1 = residenceRepo.Queryable()
                //.Include(s => s.Municipality)
                //.ThenInclude(s => s.County)
                //.Include(x => x.Agent)
                //.ThenInclude(s => s.Agency)
                //.Include(z => z.Category)
                //.Where(s => s.Id == id);

                residenceRepo.Update(residence);
                await residenceRepo.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResidenceExists(id))
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

        // POST: api/Residence
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Residence>> PostResidence(Residence residence)
        {
            
            await residenceRepo.AddAsync(residence);
            await residenceRepo.SaveChangesAsync();
            //residenceRepo.SavedResidance(residence);

            return CreatedAtAction("GetResidence", new { id = residence.Id }, residence);
        }

        // DELETE: api/Residence/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResidence(int id)
        {
            var residence = await residenceRepo.GetAsync(id);
            if (residence == null)
            {
                return NotFound();
            }

            residenceRepo.Delete(residence);
            await residenceRepo.SaveChangesAsync();

            return Ok();
        }

        private bool ResidenceExists(int id)
        {
            return residenceRepo.Queryable().Any(e => e.Id == id);
        }
    }
}
