using AutoMapper;
using WebApplication1.Models;
using WebApplication1.Shared.DTOS;

namespace WebApplication1
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<BlogDto, Blog>();
            CreateMap<Blog,BlogDto>();
            CreateMap<BlogCrationDto,Blog>();
            CreateMap<Category, CategoryWithBlogDto>();
            CreateMap<UpdateCategoryDto, Category>();
            CreateMap<UpdateCategoryDto, CategoryDto>();
            
        }
    }
}