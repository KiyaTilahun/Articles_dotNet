using WebApplication1.Models;
using WebApplication1.Shared.DTOS;
using WebApplication1.Shared.RequestFeatures;

namespace WebApplication1.Contracts
{
    public interface ICategoryService
    {
        public IEnumerable<CategoryDto> GetAllCategories(bool trackChanges);
        public CategoryWithBlogDto GetCategory(Guid companyId, bool trackChanges);
        CategoryDto CreateCategory(CategoryCreationDto category);
        void DeleteCategory(Guid CategoryId, bool trackChanges);
        
        CategoryDto UpdateCategory(Guid CategoryId,UpdateCategoryDto category);
        public Task<(IEnumerable<Category>, MetaData metaData)> GetAsync(CategoryParameters parameters,bool trackChanges);
    }
}