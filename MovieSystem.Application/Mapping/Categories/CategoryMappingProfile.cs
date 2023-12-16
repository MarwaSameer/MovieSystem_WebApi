using AutoMapper;
using MoviesSystem.Domain.Entities;
using MovieSystem.Application.Feature.Categories.Commands.Models;
using MovieSystem.Application.Feature.Categories.Queries.Response;

namespace MovieSystem.Application.Mapping.Categories
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category, GetCategoryListResponse>();

            CreateMap<AddCategoryCommand, Category>();
            CreateMap<UpdateCategoryCommand, Category>();

        }
    }
}
