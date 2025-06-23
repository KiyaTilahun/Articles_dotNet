using WebApplication1.Contracts;

namespace WebApplication1.Repository
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICategoryService> _categoryService;
        private readonly Lazy<IBlogService> _blogService;
        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _categoryService = new Lazy<ICategoryService>(() => new
                CategoryService(repositoryManager));
            _blogService = new Lazy<IBlogService>(() => new
                BlogService(repositoryManager));
        }


        public ICategoryService CategoryService => _categoryService.Value;

        public IBlogService BlogService => _blogService.Value;
    }
}