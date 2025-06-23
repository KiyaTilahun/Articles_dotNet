using Microsoft.AspNetCore.Mvc;
using WebApplication1.Contracts;

namespace WebApplication1.Presentation.Controllers
{
    [Route("api/categories/{categoryId}/blogs")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IServiceManager _service;
        public BlogController(IServiceManager service) => _service = service;

        [HttpGet]
        public IActionResult GetEmployeesForCompany(Guid categoryId)
        {
            var blogs = _service.BlogService.GetAllBlogs(categoryId, trackChanges:
            false);
            return Ok(blogs);
        }
    }
}