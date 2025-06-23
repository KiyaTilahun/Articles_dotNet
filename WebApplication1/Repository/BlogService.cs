using WebApplication1.Contracts;

namespace WebApplication1.Repository
{
    internal sealed class BlogService:IBlogService
    {
        private readonly IRepositoryManager _repository;

        public BlogService(IRepositoryManager repository)
        {
            _repository = repository;
        }
    }
}