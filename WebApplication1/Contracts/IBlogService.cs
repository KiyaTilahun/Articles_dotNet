using WebApplication1.Shared.DTOS;

namespace WebApplication1.Contracts
{
    public interface IBlogService
    {

        public IEnumerable<BlogDto> GetAllBlogs(Guid categoryId, bool trackChanges);
        public BlogDto GetBlog(Guid companyId, Guid id, bool trackChanges);
        public BlogDto CreateBlog(BlogCrationDto blog,Guid categoryId);
        public void DeleteBlog(Guid categoryId,Guid blog);
    }
}