using AutoMapper;
using HemSok.Constants;
using HemSok.Data;
using HemSok.Models;
using Microsoft.AspNetCore.Authorization;
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

            return (agents == null) ? NotFound("Could not find any agents") : Ok(agents);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Agent>> GetAgent(string id)
        {
            var agent = await agentRepository
                .Queryable()
                .Include(a => a.Agency)
                .FirstOrDefaultAsync(a => a.Id == id);

            return (agent == null) ? NotFound("Could not find any agent with that id") : Ok(agent);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = UserRoles.SuperAdminAndAdmin)]
        public async Task<ActionResult> DeleteAgent(string id)
        {
            var agent = await agentRepository.GetAsync(id);

            if (agent == null)
                return NotFound("Could not find any agent with that id");

            agentRepository.Delete(agent);
            await agentRepository.SaveChangesAsync();

            return Ok();
        }

        [HttpPost]
        [Authorize(Roles = UserRoles.SuperAdminAndAdmin)]
        public async Task<ActionResult> PostAgent([FromBody] Agent agent)
        {
            //var agent = _mapper.Map<Agent>(agentDTO);

            if (agent == null)
                return NotFound("No agent data sent");

            await agentRepository.AddAsync(agent);

            agencyRepository.Entry(agent.Agency, EntityState.Unchanged);

            await agentRepository.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        [Authorize]
        public async Task<ActionResult> PutAgent([FromBody] Agent agent)
        {
            if (agent == null)
            {
                return BadRequest("No agent data sent");
            }

            if (!AgentExists(agent.Id))
            {
                return NotFound("No agent found to update");
            }

            agentRepository.Update(agent);

            //agencyRepository.Entry(agent.Agency, EntityState.Unchanged);

            await agentRepository.SaveChangesAsync();

            return Ok();
        }
        private bool AgentExists(string id)
        {
            return agentRepository.Queryable().Any(e => e.Id == id);
        }
    }
}
