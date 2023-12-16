using AutoMapper;
using MoviesSystem.Domain.Entities;
using MovieSystem.Application.Feature.Categories.Commands.Models;
using MovieSystem.Application.Feature.Likes.Commands.Models;
using MovieSystem.Application.Feature.Likes.Queries.Response;

namespace MovieSystem.Application.Mapping.Movies
{
    public class LikesMappingProfile : Profile
    {
        public LikesMappingProfile()
        {
            CreateMap<Like, GetLikeListResponse>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User.UserName))
                .ForMember(dest => dest.MovieName, opt => opt.MapFrom(src => src.Movie.MovieName));

            CreateMap<AddLikeCommand, Like>();
            CreateMap<UpdateLikeCommand, Like>();
        }
    }
}
