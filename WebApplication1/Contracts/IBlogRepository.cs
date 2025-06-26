using WebApplication1.Models;
using WebApplication1.Shared.DTOS;

namespace WebApplication1.Contracts
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> GetAllBlogs(Guid categoryId, bool trackChanges);
        Blog GetBlog(Guid categoryId, Guid id, bool trackChanges);
        void CreateBlog(Blog blog);
        void DeleteBlog(Blog blog);
        // In ICategoryRepository
       
    }
}