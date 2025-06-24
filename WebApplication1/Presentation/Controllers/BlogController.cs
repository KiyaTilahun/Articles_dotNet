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
        public IActionResult GetBlogsForCategory(Guid categoryId)
        {
            var blogs = _service.BlogService.GetAllBlogs(categoryId, trackChanges:
            false);
            return Ok(blogs);
        }

        [HttpGet("{id}")]
        public IActionResult GetSpecificBlogForCategory(Guid categoryId, Guid id) // Corrected signature
        {
            // You would typically call a service method to get a single blog here
            var blog = _service.BlogService.GetBlog(categoryId, id, trackChanges: false);
            if (blog == null)
            {
                return NotFound(); // Or a custom error
            }
            return Ok(blog);
        }
    }
}