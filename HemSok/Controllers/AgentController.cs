using AutoMapper;
using HemSok.Data;
using HemSok.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

/*
 Author: Fredrik Blixt, Emil Waara
 */
namespace HemSok.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentController : ControllerBase
    {
        private readonly IRepository<Agent> agentRepository;
        private readonly IRepository<Agency> agencyRepository;
        private readonly IMapper _mapper;

        public AgentController(IRepository<Agent> agentRepository, IRepository<Agency> agencyRepository, IMapper mapper)
        {
            this.agentRepository = agentRepository;
            this.agencyRepository = agencyRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAgents()
        {
            var agents = await agentRepository
                .Queryable()
                .Include(a => a.Agency)
                .ToListAsync();

            if (agents == null)
                return NotFound();

            return Ok(agents);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Agent>> GetAgent(string id)
        {
            var agent = await agentRepository
                .Queryable()
                .Include(a => a.Agency)
                .FirstOrDefaultAsync(a => a.Id == id);
            
            if (agent == null)
                return NotFound();

            return Ok(agent);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAgent(string id)
        {
            var agent = await agentRepository.GetAsync(id);

            if (agent == null)
                return NotFound();

            agentRepository.Delete(agent);
            await agentRepository.SaveChangesAsync();

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> PostAgent([FromBody] AgentDTO agentDTO)
        {
            var agent = _mapper.Map<Agent>(agentDTO);

            if (agent == null)
                return NotFound();

            await agentRepository.AddAsync(agent);

            agencyRepository.Entry(agent.Agency, EntityState.Unchanged);

            await agentRepository.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutAgent([FromBody] AgentDTO agentDTO)
        {
            var agent = _mapper.Map<Agent>(agentDTO);

            if (agent == null)
                return NotFound();

            //agentRepository.Update(agent);

            //agencyRepository.Entry(agent.Agency, EntityState.Unchanged);

            //await agentRepository.SaveChangesAsync();

            return Ok();
        }


        // var newAgent = _mapper.Map<AgentDTO>(agent);
    }
}
