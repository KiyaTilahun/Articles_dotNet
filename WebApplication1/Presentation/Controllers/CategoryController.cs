using FluentValidation;
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

        [HttpGet("{id:guid}", Name = "GetCategory")]
        public IActionResult GetCategory(Guid id)
        {

            var company = _categoryService.CategoryService.GetCategory(id, trackChanges: false);
            return Ok(company);


        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(
            [FromBody] CategoryCreationDto cat,
            IValidator<CategoryCreationDto> validator)
        {
            var validationResult = await validator.ValidateAsync(cat);

            if (!validationResult.IsValid)
            {
                var errorsDictionary = validationResult.Errors
                    .GroupBy(x => x.PropertyName)
                    .ToDictionary(
                        g => g.Key,
                        g => g.Select(x => x.ErrorMessage).ToArray()
                    );

                var problemDetails = new HttpValidationProblemDetails(errorsDictionary)
                {
                    Status = StatusCodes.Status422UnprocessableEntity,
                    Title = "Validation Error",
                    Detail = "One or more validation errors occurred.",
                    Instance = HttpContext.Request.Path
                };

                return UnprocessableEntity(problemDetails);
            }

            var category = _categoryService.CategoryService.CreateCategory(cat);
            return CreatedAtRoute("GetCategory", new {id = category.Id}, category);
        }
    

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteCategory(Guid id)
        {
            _categoryService.CategoryService.DeleteCategory(id,false);
            return NoContent();
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdateCategory([FromBody] UpdateCategoryDto cat,Guid id)
        {
            var updated = _categoryService.CategoryService.UpdateCategory(id, cat);
            return CreatedAtRoute("GetCategory",new {id=id},updated);
        }
        
        

    }
}