using WebApplication1.Shared.DTOS;

namespace WebApplication1.Contracts
{
    public interface ICategoryService
    {
        public IEnumerable<CategoryDto> GetAllCategories(bool trackChanges);
        public CategoryDto GetCategory(Guid companyId, bool trackChanges);
    }
}