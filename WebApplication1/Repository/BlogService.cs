using AutoMapper;
using WebApplication1.Contracts;
using WebApplication1.Exceptions;
using WebApplication1.Models;
using WebApplication1.Shared.DTOS;

namespace WebApplication1.Repository
{
    internal sealed class BlogService : IBlogService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public BlogService(IRepositoryManager repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<BlogDto> GetAllBlogs(Guid categoryId, bool trackChanges)
        {
            try
            {
                var blogs =
                _repository.Blog.GetAllBlogs(categoryId, trackChanges);
                if (blogs == null)
                {
                    throw new CompanyNotFoundException(categoryId);
                }
                var blogsdto = _mapper.Map<IEnumerable<BlogDto>>(blogs);
                return blogsdto;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public BlogDto GetBlog(Guid categoryId, Guid blogId, bool trackChanges)
        {
            var blog = _repository.Blog.GetBlog(categoryId, blogId, false);
            var blogDto = _mapper.Map<BlogDto>(blog);

            return blogDto;
        }

        public BlogDto CreateBlog(BlogCrationDto blog, Guid categoryId)
        {
           var newBlog=_mapper.Map<Blog>(blog);
           newBlog.CategoryId = categoryId;
           _repository.Blog.CreateBlog(newBlog);
           _repository.Save();
           return  _mapper.Map<BlogDto>(newBlog);
        }
        

        public void DeleteBlog(Guid categoryId,Guid blog)
        {
            var blognew=_repository.Blog.GetBlog(categoryId, blog, false);
            _repository.Blog.DeleteBlog(blognew);
            _repository.Save();
        }
    }
}