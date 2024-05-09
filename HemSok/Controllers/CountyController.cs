using HemSok.Data;
using HemSok.Models;
using Microsoft.AspNetCore.Mvc;

/*
 Author: Emil Waara
 */
namespace HemSok.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountyController : ControllerBase
    {
        private readonly IRepository<County> countyRepository;

        public CountyController(IRepository<County> countyRepository)
        {
            this.countyRepository = countyRepository;
        }

        // GET: api/County
        [HttpGet]
        public async Task<ActionResult<IEnumerable<County>>> GetCounties()
        {
            var counties = await countyRepository.GetAllAsync();
            return (counties == null) ? NotFound("Could not find any counties") : Ok(counties);
        }

        // GET: api/County/5
        [HttpGet("{id}")]
        public async Task<ActionResult<County>> GetCounty(int id)
        {
            var county = await countyRepository.GetAsync(id);
            return (county == null) ? NotFound("Could not find the county with id") : Ok(county);
        }
    }
}
