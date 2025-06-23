namespace WebApplication1.Contracts
{
    public interface IRepositoryManager
    {
        ICategoryRepository Category { get; }
        IBlogRepository Blog { get; }
        void Save();
    }
}