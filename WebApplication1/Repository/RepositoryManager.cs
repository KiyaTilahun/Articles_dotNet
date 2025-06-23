using WebApplication1.Contracts;
using WebApplication1.Data;

namespace WebApplication1.Repository
{
    public sealed class RepositoryManager:IRepositoryManager
    {
        
        private readonly ApplicationDbContext _repositoryContext;
        private readonly Lazy<ICategoryRepository> _categoryRepository;
        private readonly Lazy<IBlogRepository> _blogRepository;
        public RepositoryManager(ApplicationDbContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _categoryRepository=new Lazy<ICategoryRepository>(() => new
                CategoryRepository(repositoryContext));
            _blogRepository= new Lazy<IBlogRepository>(() => new
                BlogRepository(repositoryContext));
        }
        public ICategoryRepository Category => _categoryRepository.Value;
        public IBlogRepository Blog => _blogRepository.Value;
        public void Save() => _repositoryContext.SaveChanges();
    }
}