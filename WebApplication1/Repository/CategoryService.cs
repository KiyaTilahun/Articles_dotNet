using WebApplication1.Contracts;

namespace WebApplication1.Repository
{
    public class CategoryService:ICategoryService
    {
        private readonly IRepositoryManager _repository;
        public CategoryService(IRepositoryManager repository)
        {
            _repository = repository;
        }
    }
}