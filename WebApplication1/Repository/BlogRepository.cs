namespace WebApplication1.Repository
{
    using Microsoft.EntityFrameworkCore;
    using WebApplication1.Contracts;
    using WebApplication1.Data;
    using WebApplication1.Models;

    public class BlogRepository : RepositoryBase<Blog>, IBlogRepository
    {
        public BlogRepository(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Blog> GetAllBlogs(Guid categoryId, bool trackChanges) =>
             FindByCondition(c => c.CategoryId.Equals(categoryId), trackChanges).Include(b => b.Category)
            .OrderBy(c => c.Title)
            .ToList();

        public Blog GetBlog(Guid categoryId, Guid id, bool trackChanges) => FindByCondition(c => c.Id.Equals(id), trackChanges).Include(b => b.Category).SingleOrDefault();

        public void CreateBlog(Blog blog) => RepositoryContext.Set<Blog>().Add(blog);
        public void DeleteBlog(Blog blog) => Delete(blog);
    }

}
