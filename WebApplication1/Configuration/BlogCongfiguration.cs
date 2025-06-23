using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Configuration
{
    public class BlogCongfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            Guid[] allSeededCategoryIds = new Guid[]
                        {
                            new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                             new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                             new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811")
                           };

            var random = new Random();
            var blogsToSeed = new List<Blog>();
            for (int i = 0; i < 20; i++)
            {
                int randomIndex = random.Next(allSeededCategoryIds.Length);
                Guid randomCategoryId = allSeededCategoryIds[randomIndex];
                blogsToSeed.Add(new Blog
                {
                    Id = Guid.NewGuid(),
                    Title = $"title - {i + 1}",
                    Author = $"Author- {i + 1}",
                    CategoryId = randomCategoryId // Assign the known ID
                });
            }
            builder.HasData(blogsToSeed);
            //builder.HasData(
            //    new Blog
            //    {
            //        Id = Guid.Parse("c9d4c053-49d6-45b0-bd89-eb39b56360c7"), // Use a unique GUID for each entry
            //        Title = "The Future of AI",
            //        Author = "Jane Doe",
            //        CategoryId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a")
            //    },
            //    new Blog
            //    {
            //        Id = Guid.Parse("3d49079a-0d8b-4a57-897d-411306121f1d"),
            //        Title = "Exploring the Amalfi Coast",
            //        Author = "John Smith",
            //        CategoryId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a")
            //    },
            //    new Blog
            //    {
            //        Id = Guid.Parse("f9f0f9f0-f9f0-f9f0-f9f0-f9f0f9f0f9f0"),
            //        Title = "10 Delicious Pasta Recipes",
            //        Author = "Emily White",
            //        CategoryId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a")
            //    }
            //);
        }
    }
}
