using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using WebApplication1.Contracts;
using WebApplication1.Data;
using WebApplication1.Extensions;
using WebApplication1.Models;
using WebApplication1.Shared.DTOS;
using WebApplication1.Shared.RequestFeatures;

namespace WebApplication1.Repository
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext repositoryContext)
            : base(repositoryContext)
        {
        }


            public async Task<PagedList<Category>> GetAllCategoriesAsync(CategoryParameters parameters,bool trackChanges)
            {
                // if (parameters.CheckValidMin())
                // {
                //     throw new NotImplementedException("hwllo");
                // }
                //
            
              
                
                var categoriesQuery =  FindByCondition(c=> c.CreatedAt>=parameters.MinCreatedAt,true).Search(parameters.SearchTerm).Sort(parameters.OrderBy);
         

                ;
               var listNew=await categoriesQuery.ToListAsync();
               return PagedList<Category>   
                   .ToPagedList(listNew, parameters.PageNumber,
                       parameters.PageSize);
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