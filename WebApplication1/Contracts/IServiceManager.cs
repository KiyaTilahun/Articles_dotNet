namespace WebApplication1.Contracts
{
    public class IServiceManager
    {
        ICategoryService CategoryService { get; }
        IBlogService BlogService { get; }
    }
}