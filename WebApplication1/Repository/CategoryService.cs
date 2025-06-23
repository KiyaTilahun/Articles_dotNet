using WebApplication1.Contracts;
using WebApplication1.Exceptions;
using WebApplication1.Shared.DTOS;

namespace WebApplication1.Repository
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepositoryManager _repository;
        public CategoryService(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public IEnumerable<CategoryDto> GetAllCategories(bool trackChanges)
        {
            try
            {
                var categories =
                _repository.Category.GetAllCategories(trackChanges);
                var categoriesDto = categories.Select(c =>
new CategoryDto(c.Id, (c.Name + " " + c.Id) ?? ""))
.ToList();
                return categoriesDto;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public CategoryDto GetCategory(Guid companyId, bool trackChanges)
        {
            var category = _repository.Category.GetCategory(companyId, trackChanges);

            if (category is null)
                throw new CompanyNotFoundException(companyId);
            return new CategoryDto
                (
                    category.Id,
                   category.Name
                );


        }
    }
}