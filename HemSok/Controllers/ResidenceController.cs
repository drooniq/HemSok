using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HemSok.Data;
using HemSok.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
/*
 Author: Marcus Karlsson
 */
namespace HemSok.Controllers
{  
    [Route("api/[controller]")]
    [ApiController]
    public class ResidenceController : ControllerBase
    {
        private readonly IRepository<Agent> agentRepository;
        private readonly IRepository<Agency> agencyRepository;
        private readonly IRepository<Residence> residenceRepository;
        private readonly IRepository<Category> categoryRepository;
        private readonly IRepository<Municipality> municipalityRepository;
        private readonly IRepository<County> countyRepository;
        private readonly IMapper mapper;

        public ResidenceController(
              IRepository<Agent> agentRepository
            , IRepository<Agency> agencyRepository
            , IRepository<Residence> residenceRepository
            , IRepository<Category> categoryRepository
            , IRepository<Municipality> municipalityRepository
            , IRepository<County> countyRepository
            , IMapper mapper)
        {
            this.agentRepository = agentRepository;
            this.agencyRepository = agencyRepository;
            this.residenceRepository = residenceRepository;
            this.categoryRepository = categoryRepository;
            this.municipalityRepository = municipalityRepository;
            this.countyRepository = countyRepository;
            this.mapper = mapper;
        }

        // GET: api/Residence
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Residence>>> GetResidences()
        {
            var residencies = await residenceRepository.Queryable()
                .Include(s => s.Municipality)
                .ThenInclude(s => s.County)
                .Include(s => s.Agent)
                .ThenInclude(s => s.Agency)
                .Include(s => s.Category)
                .ToListAsync();

            return (residencies == null) ? NotFound("Could not find any residences") : Ok(residencies);
        }

        // GET: api/Residence/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Residence>> GetResidence(int id)
        {
            var residence = await residenceRepository.Queryable()
               .Include(s => s.Municipality)
               .ThenInclude(s => s.County)
               .Include(s => s.Agent)
               .ThenInclude(s => s.Agency)
               .Include(s => s.Category)
               .FirstOrDefaultAsync(s => s.Id == id);

            return (residence == null) ? NotFound("Could not find the residence with that id") : Ok(residence);
        }

        // PUT: api/Residence/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<IActionResult> PutResidence([FromBody] Residence residence)
        {
            if (residence == null)
            {
                return NotFound("Could not find residence data to update");
            }        

            residenceRepository.Update(residence);
            await residenceRepository.SaveChangesAsync();    

            return Ok();
        }

        // POST: api/Residence
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Residence>> PostResidence(ResidenceDTO residenceDTO)
        {
            var residence = mapper.Map<Residence>(residenceDTO);
            residence.ImagePaths = new List<string>();

            if (residence == null)
                return NotFound("No residence to post");

            try
            {
                await residenceRepository.AddAsync(residence);

                categoryRepository.Entry(residence.Category, EntityState.Unchanged);
                agentRepository.Entry(residence.Agent, EntityState.Unchanged);
                agencyRepository.Entry(residence.Agent.Agency, EntityState.Unchanged);
                municipalityRepository.Entry(residence.Municipality, EntityState.Unchanged);
                countyRepository.Entry(residence.Municipality.County, EntityState.Unchanged);

                await residenceRepository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return CreatedAtAction("GetResidence", new { id = residence.Id }, residence);
        }

        // DELETE: api/Residence/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResidence(int id)
        {
            var residence = await residenceRepository.GetAsync(id);

            if (residence == null)
            {
                return NotFound("Could not find a residence with that id");
            }

            residenceRepository.Delete(residence);
            await residenceRepository.SaveChangesAsync();

            return Ok();
        }

        private bool ResidenceExists(int id)
        {
            return residenceRepository.Queryable().Any(e => e.Id == id);
        }
    }
}
