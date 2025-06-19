namespace WebApplication1.Models
{
    public class Blog
    {
        public Guid Id { get; set; }
        public string Title { get; set; }=string.Empty;
        public string Author { get; set; }= string.Empty;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
