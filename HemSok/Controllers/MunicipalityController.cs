using HemSok.Data;
using HemSok.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

/*
 Author: Emil Waara
 */

namespace HemSok.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MunicipalityController : ControllerBase
    {
        private readonly IRepository<Municipality> municipalityRepository;

        public MunicipalityController(IRepository<Municipality> municipalityRepository)
        {
            this.municipalityRepository = municipalityRepository;
        }

        // GET: api/Municipality
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Municipality>>> GetMunicipalities()
        {
            var municipalities = await municipalityRepository
                .Queryable()
                .Include(c=>c.County)
                .ToListAsync();

            if (municipalities == null)
            {
                return NotFound();
            }

            return Ok(municipalities);
        }

        // GET: api/Municipality/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Municipality>> GetMunicipality(int id)
        {
            var municipality = await municipalityRepository
                .Queryable()
                .Include(c=>c.County)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (municipality == null)
            {
                return NotFound();
            }

            return Ok(municipality);
        }
    }
}
