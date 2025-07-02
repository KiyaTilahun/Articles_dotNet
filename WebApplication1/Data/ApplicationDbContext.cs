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

        
        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            AddTimestamps();
            return await base.SaveChangesAsync(cancellationToken);
        }

        private void AddTimestamps()
        {
            var entries = ChangeTracker.Entries()
                .Where(e => e.Entity is Category && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    ((Category)entry.Entity).CreatedAt = DateTime.UtcNow; 
                }
              
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Blog>()
                .HasOne(b => b.Category)            
                .WithMany(c => c.Blogs)            
                .HasForeignKey(b => b.CategoryId)   
                .OnDelete(DeleteBehavior.Cascade); 
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new BlogCongfiguration());
            
            // modelBuilder.Entity<User>().OwnsOne(u => u.Email);
        
        }

    }
}
