using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Configuration;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext:IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
: base(options)
        { }

        public DbSet<Category>? Categories { get; set; }
        public DbSet<Blog>? Blogs { get; set; }
        // public DbSet<User>? Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Blog>()
                .HasOne(b => b.Category)             // A Blog has one Category
                .WithMany(c => c.Blogs)              // A Category has many Blogs
                .HasForeignKey(b => b.CategoryId)    // The foreign key is CategoryId in the Blog entity
                .OnDelete(DeleteBehavior.Cascade); 
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new BlogCongfiguration());
            
            // modelBuilder.Entity<User>().OwnsOne(u => u.Email);
        
        }

    }
}
