using AutoMapper;
using MoviesSystem.Domain.Entities;
using MovieSystem.Application.Feature.Rates.Commands.Models;
using MovieSystem.Application.Feature.Rates.Queries.Response;
namespace MovieSystem.Application.Mapping.Movies
{
    public class RatesMappingProfile : Profile
    {
        public RatesMappingProfile()
        {

            // Mapping from Rate to GetRateListResponse
            CreateMap<Rate, GetRateListResponse>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User.UserName))
                .ForMember(dest => dest.MovieName, opt => opt.MapFrom(src => src.Movie.MovieName));

            // Mapping from AddRateCommand to Rate
            CreateMap<AddRateCommand, Rate>();

            // Mapping from UpdateRateCommand to Rate
            CreateMap<UpdateRateCommand, Rate>();

            /*   // Custom mapping for a List of Rate to Response<IEnumerable<GetRateListResponse>>
               CreateMap<List<Rate>, Response<IEnumerable<GetRateListResponse>>>()
                   .ConvertUsing((source, destination, context) =>
                   {
                       var response = new Response<IEnumerable<GetRateListResponse>>(
                           context.Mapper.Map<IEnumerable<GetRateListResponse>>(source)
                       );
                       return response;
                   });*/
        }
    }
}
