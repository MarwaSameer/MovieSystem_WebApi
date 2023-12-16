using AutoMapper;
using MoviesSystem.Domain.Entities;
using MovieSystem.Application.Feature.Movies.Commands.Models;
using MovieSystem.Application.Feature.Movies.Queries.Response;

namespace MovieSystem.Application.Mapping.Movies
{
    public class MoviesMappingProfile : Profile
    {
        public MoviesMappingProfile()
        {
            CreateMap<Movie, GetMovieListResponse>();
            //CreateMap<AddMovieCommand, Movie>()
            //    .ForMember(dest => dest.TypeId, opt => opt.MapFrom(src => src.MovieTypeId))
            //    .ForPath(dest => dest.MovieCategorys.Select(a => a.CategoryId), opt => opt.MapFrom(src => src.CategoriesId));
            //// .ForMember(dest => dest.MovieCategorys.Select(a=>a.MovieId), opt => opt.MapFrom(src => src.));


            //CreateMap<AddMovieCommand, Movie>().ReverseMap()
            //    .ForMember(dest => dest.MovieTypeId, opt => opt.MapFrom(src => src.TypeId))
            //    .ForMember(dest => dest.CategoriesId, opt => opt.MapFrom(src => src.MovieCategorys.Select(a => a.CategoryId)));

            CreateMap<AddMovieCommand, Movie>().ReverseMap()
             .ForMember(dest => dest.MovieTypeId, opt => opt.MapFrom(src => src.TypeId))
             .ForMember(dest => dest.CategoriesId, opt => opt.MapFrom(src => src.MovieCategorys.Select(a => a.CategoryId)));


            CreateMap<UpdateMovieCommand, Movie>();

        }
    }
}
