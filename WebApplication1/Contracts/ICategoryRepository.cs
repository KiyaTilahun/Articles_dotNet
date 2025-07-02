using WebApplication1.Models;
using WebApplication1.Shared.DTOS;
using WebApplication1.Shared.RequestFeatures;

namespace WebApplication1.Contracts
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories(bool trackChanges);
        Category GetCategory(Guid categoryId, bool trackChanges);
        void CreateCategory(Category category);
        void DeleteCategory(Category category);
        void UpdateCategory(Category category,UpdateCategoryDto categoryDto);
        Task<PagedList<Category>> GetAllCategoriesAsync(CategoryParameters parameters,bool trackChanges);
        
    
    }
}