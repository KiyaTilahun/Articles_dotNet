using AutoMapper;
using FluentEmail.Core;
using WebApplication1.Contracts;

namespace WebApplication1.Repository
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICategoryService> _categoryService;
        private readonly Lazy<IBlogService> _blogService;
        private readonly Lazy<IEmailService> _emailService;
        public ServiceManager(IRepositoryManager repositoryManager,IMapper mapper,IFluentEmail fluentEmail)
        {
            _categoryService = new Lazy<ICategoryService>(() => new
                CategoryService(repositoryManager,mapper));
            _blogService = new Lazy<IBlogService>(() => new
                BlogService(repositoryManager,mapper));
            _emailService=new Lazy<IEmailService>(()=>new EmailService(fluentEmail));
        }


        public ICategoryService CategoryService => _categoryService.Value;

        public IBlogService BlogService => _blogService.Value;
        public IEmailService EmailService
        {
            get
            {
                return _emailService.Value;
            }
        }
    }
}