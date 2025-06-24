using WebApplication1.Models;

namespace WebApplication1.Contracts
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories(bool trackChanges);
        Category GetCategory(Guid categoryId, bool trackChanges);
        void CreateCategory(Category category);
    }
}