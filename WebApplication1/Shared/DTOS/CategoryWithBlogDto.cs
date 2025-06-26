namespace WebApplication1.Shared.DTOS
{
    public class CategoryWithBlogDto
    {
        public Guid Id { get; set; }
        public string Name  { get; set; }
        public ICollection<BlogDto> Blogs { get; set; } = new List<BlogDto>();
        
    }
}