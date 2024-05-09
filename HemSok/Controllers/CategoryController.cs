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
    public class CategoryController : ControllerBase
    {
        private readonly IRepository<Category> categoryRepository;

        public CategoryController(IRepository<Category> categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        // GET: api/Category
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            var categories = await categoryRepository.GetAllAsync();
            return (categories == null) ? NotFound("Could not find any categories") : Ok(categories);
        }

        // GET: api/Category/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            var category = await categoryRepository.GetAsync(id);
            return (category == null) ? NotFound("Could not find any category with id") : Ok(category);
        }
    }
}
