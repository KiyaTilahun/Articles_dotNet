using WebApplication1.Contracts;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext repositoryContext)
            : base(repositoryContext)
        {
        }



        public IEnumerable<Category> GetAllCategories(bool trackChanges) =>
            FindAll(trackChanges)
                .OrderBy(c => c.Name)
                .ToList();

        public Category GetCategory(Guid categoryId, bool trackChanges)
             =>
            FindByCondition(c => c.Id.Equals(categoryId), trackChanges)
            .SingleOrDefault();


        public void CreateCategory(Category category) => Create(category);
    }

}