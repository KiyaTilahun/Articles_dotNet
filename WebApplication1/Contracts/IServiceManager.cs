namespace WebApplication1.Contracts
{
    public interface IServiceManager
    {
        ICategoryService CategoryService { get; }
        IBlogService BlogService { get; }
    }
}