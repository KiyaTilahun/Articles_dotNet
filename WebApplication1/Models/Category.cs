using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public DateTime CreatedAt { get; set; }
        public ICollection<Blog> Blogs { get; set; } = new List<Blog>();


    }
}
