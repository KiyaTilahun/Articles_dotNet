using Microsoft.AspNetCore.Mvc;
using WebApplication1.Contracts;
using WebApplication1.Shared.DTOS;

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

        [HttpGet("{id:guid}", Name = "GetBlog")]
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

        [HttpPost]
        public IActionResult CreateBlog([FromBody] BlogCrationDto blog,Guid categoryId)
        {
            var newblog=_service.BlogService.CreateBlog(blog,categoryId);
            
        return CreatedAtRoute(
                "GetBlog",
                new { categoryId = categoryId, id = newblog.Id }, // <-- Provide BOTH route parameters
                newblog // The object to return in the response body
            );
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteBlog(Guid categoryId, Guid id)
        {
            _service.BlogService.DeleteBlog(categoryId, id);
            return NoContent();
        }
    }
}