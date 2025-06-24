using Microsoft.AspNetCore.Mvc;
using WebApplication1.Contracts;
using WebApplication1.Shared.DTOS;

namespace WebApplication1.Presentation.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly IServiceManager _categoryService;
        public CategoryController(IServiceManager service)
        {

            _categoryService = service;
        }
        [HttpGet]
        public IActionResult GetCategories()
        {
            try
            {

                var categories = _categoryService.CategoryService.GetAllCategories(trackChanges: false);
                return Ok(categories);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetCompany(Guid id)
        {

            var company = _categoryService.CategoryService.GetCategory(id, trackChanges: false);
            return Ok(company);


        }

        [HttpPost]
        public IActionResult CreateCategory([FromBody] CategoryCreationDto cat)
        {
            var category=_categoryService.CategoryService.CreateCategory(cat);
            return Ok(category);
        }

    }
}