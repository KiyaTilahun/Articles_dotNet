using WebApplication1.Contracts;
using WebApplication1.Exceptions;
using WebApplication1.Shared.DTOS;

namespace WebApplication1.Repository
{
    internal sealed class BlogService : IBlogService
    {
        private readonly IRepositoryManager _repository;

        public BlogService(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public IEnumerable<BlogDto> GetAllBlogs(Guid categoryId, bool trackChanges)
        {
            try
            {
                var blogs =
                _repository.Blog.GetAllBlogs(categoryId, trackChanges);
                if (blogs == null)
                {
                    throw new CompanyNotFoundException(categoryId);
                }
                var blogsdto = blogs.Select(c =>
                    new BlogDto(c.Id, (c.Title + " " + c.Id) ?? "", c.CategoryId, c.Category?.Name))
                    .ToList();
                return blogsdto;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public BlogDto GetBlog(Guid categoryId, Guid blogId, bool trackChanges)
        {
            var blog = _repository.Blog.GetBlog(categoryId, blogId, false);
            var blogDto = new BlogDto(
                blog.Id,
                blog.Title ?? "",
                blog.CategoryId,
                blog.Category?.Name ?? "N/A"
            );

            return blogDto;
        }
    }
}