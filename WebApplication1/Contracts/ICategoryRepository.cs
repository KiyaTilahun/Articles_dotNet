using WebApplication1.Models;
using WebApplication1.Shared.DTOS;

namespace WebApplication1.Contracts
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories(bool trackChanges);
        Category GetCategory(Guid categoryId, bool trackChanges);
        void CreateCategory(Category category);
        void DeleteCategory(Category category);
        void UpdateCategory(Category category,UpdateCategoryDto categoryDto);
    
    }
}