using AutoMapper;
using WebApplication1.Contracts;
using WebApplication1.Exceptions;
using WebApplication1.Models;
using WebApplication1.Shared.DTOS;

namespace WebApplication1.Repository
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        
        public CategoryService(IRepositoryManager repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    
        public CategoryDto CreateCategory(CategoryCreationDto category)
        {
            var cat = new Category
            {
                Name = category.Name
            };
            _repository.Category.CreateCategory(cat);
            _repository.Save();
            return new CategoryDto(cat.Id, cat.Name);
        }

        public void DeleteCategory(Guid CategoryId, bool trackChanges)
        {
            var cat = _repository.Category.GetCategory(CategoryId, trackChanges);
           _repository.Category.DeleteCategory(cat);
           _repository.Save();
        }

        public CategoryDto UpdateCategory(Guid CategoryId, UpdateCategoryDto category)
        {
            var updateCategory = _repository.Category.GetCategory(CategoryId, true);
            _mapper.Map(category, updateCategory);
            _repository.Save();
            return _mapper.Map<CategoryDto>(updateCategory);
        }


        public IEnumerable<CategoryDto> GetAllCategories(bool trackChanges)
        {
            try
            {
                var categories =
                _repository.Category.GetAllCategories(trackChanges);
                var categoriesDto = _mapper.Map<List<CategoryDto>>(categories);
                return categoriesDto;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

            public CategoryWithBlogDto GetCategory(Guid companyId, bool trackChanges)
            {
                var category = _repository.Category.GetCategory(companyId, trackChanges);
                if (category is null)
                    throw new CompanyNotFoundException(companyId);
                return _mapper.Map<CategoryWithBlogDto>(category);
            }
    }
}