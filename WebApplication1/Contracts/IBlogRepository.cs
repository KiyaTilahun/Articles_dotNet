using WebApplication1.Models;

namespace WebApplication1.Contracts
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> GetAllBlogs(Guid categoryId, bool trackChanges);
        Blog GetBlog(Guid categoryId, Guid id, bool trackChanges);
    }
}