using WebApplication1.Shared.DTOS;

namespace WebApplication1.Contracts
{
    public interface ICategoryService
    {
        public IEnumerable<CategoryDto> GetAllCategories(bool trackChanges);
        public CategoryWithBlogDto GetCategory(Guid companyId, bool trackChanges);
        CategoryDto CreateCategory(CategoryCreationDto category);
        void DeleteCategory(Guid CategoryId, bool trackChanges);
        
        CategoryDto UpdateCategory(Guid CategoryId,UpdateCategoryDto category);
    }
}