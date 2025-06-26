using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices.ComTypes;
using WebApplication1.Contracts;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Shared.DTOS;

namespace WebApplication1.Repository
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext repositoryContext)
            : base(repositoryContext)
        {
        }



        public IEnumerable<Category> GetAllCategories(bool trackChanges) =>
            FindAll(trackChanges)
                .OrderBy(c => c.Name)
                .ToList();

        public Category? GetCategory(Guid categoryId, bool trackChanges)
        {
            return FindByCondition(c => c.Id.Equals(categoryId), trackChanges)
                .Include(c => c.Blogs)
                .SingleOrDefault();
        }
        public void CreateCategory(Category category) => Create(category);
        public void DeleteCategory(Category category)=>Delete(category);
        public void UpdateCategory(Category category, UpdateCategoryDto categoryDto)
        {
        }

        public IEnumerable<Category> GetCategoriesByIdsAsync(IEnumerable<Guid> categoryIds, bool trackChanges)
        {
            return FindByCondition(c => categoryIds.Contains(c.Id), trackChanges)
                .ToList();
        }
    }

}