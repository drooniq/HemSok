using HemSok.Data;
using HemSok.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


/*
Author: Fredrik Blixt
*/

namespace HemSok.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentController : ControllerBase
    {
        private readonly IRepository<Agent> agentRepo;

        public AgentController(IRepository<Agent> agentRepo)
        {
            this.agentRepo = agentRepo;
        }

        // GET: api/<AgentController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Agent>>> GetAllAsync()
        {
            var agent = agentRepo.Queryable().Include( a => a.Agency);
            return Ok(agent);
        }

        // GET api/<AgentController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Agent>> GetAsync(string id)
        {
            var agent = agentRepo.Queryable().Include(a => a.Agency).Where(a => a.Id == id);
            return Ok(agent);
        }

        // POST api/<AgentController>
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] Agent agent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await agentRepo.AddAsync(agent);
            await agentRepo.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAsync), new { id = agent.Id }, agent);
        }

        // PUT api/<AgentController>/5
        [HttpPut("{Guid}")]
        public IActionResult Put(string guid, [FromBody] Agent agent)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            if (agent == null)
            {
                return NotFound();
            }
            agentRepo.Update(agent);
            agentRepo.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAsync), new { id = agent.Id }, agent);
        }

        // DELETE api/<AgentController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            Guid idet = Guid.Parse(id);
            //int idet = int.Parse(id);
            var agent = await agentRepo.GetAsync(idet);
            //var agent = agentRepo.Queryable().Include(a => a.Agency).Where(a => a.Id == id);
            agentRepo.Delete(agent);
            await agentRepo.SaveChangesAsync();
            return NoContent();
        }
    }
}
