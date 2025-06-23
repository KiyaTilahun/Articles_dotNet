using WebApplication1.Contracts;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class CategoryRepository:RepositoryBase<Category>,ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext repositoryContext)
            :base(repositoryContext)
        {
        }
        public IEnumerable<Category> GetAllCategories(bool trackChanges)=>
            FindAll(trackChanges)
                .OrderBy(c => c.Name)
                .ToList();
    }
}