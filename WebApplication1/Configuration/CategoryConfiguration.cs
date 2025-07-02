using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {

        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            
            var manualCategories = new List<Category> {
                new Category
                {
                    Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    Name = "Sam Raiden",
                    CreatedAt = new DateTime(2000, 1, 1),
                },
                new Category
                {
                    Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                    Name = "Jana McLeaf",
                    CreatedAt = new DateTime(2000, 1, 6),
                },
                new Category
                {
                    Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                    Name = "Kane Miller",
                    CreatedAt = new DateTime(2000, 1, 6),
                }
            };
      
            
            int numberOfCategories=50;
            DateTime startDate = new DateTime(2000, 1, 1);

            var categories = Enumerable.Range(1, numberOfCategories)
                .Select(i => new Category
                {
                    Id = Guid.NewGuid(),
                    Name = $"Category {i}",
                    CreatedAt = startDate.AddDays(i - 1),
                })
                .ToList();
            manualCategories.AddRange(categories);
            builder.HasData(manualCategories);
          
        }
    }
}
