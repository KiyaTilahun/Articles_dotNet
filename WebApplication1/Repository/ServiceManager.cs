using AutoMapper;
using WebApplication1.Contracts;

namespace WebApplication1.Repository
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICategoryService> _categoryService;
        private readonly Lazy<IBlogService> _blogService;
        public ServiceManager(IRepositoryManager repositoryManager,IMapper mapper)
        {
            _categoryService = new Lazy<ICategoryService>(() => new
                CategoryService(repositoryManager,mapper));
            _blogService = new Lazy<IBlogService>(() => new
                BlogService(repositoryManager,mapper));
        }


        public ICategoryService CategoryService => _categoryService.Value;

        public IBlogService BlogService => _blogService.Value;
    }
}