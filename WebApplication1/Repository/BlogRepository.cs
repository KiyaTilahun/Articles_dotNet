using WebApplication1.Contracts;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class BlogRepository:RepositoryBase<Blog>,IBlogRepository
    {
        public BlogRepository(ApplicationDbContext repositoryContext):base(repositoryContext)
        {
            
        }
    }
}