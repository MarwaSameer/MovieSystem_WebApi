using AutoMapper;
using MoviesSystem.Domain.Entities;
using MovieSystem.Application.Feature.SubScripPlan.Queries.Response;
using MovieSystem.Application.Feature.UserSubsss.Commands.Models;

namespace MovieSystem.Application.Mapping.Movies
{
    public class UserSubscriptionMappingProfile : Profile
    {
        public UserSubscriptionMappingProfile()
        {

            // Mapping from Rate to GetRateListResponse
            CreateMap<SubscriptionPlan, GetSubscriptionPlanListResponse>();


            // Mapping from AddRateCommand to Rate
            CreateMap<AddUserSubscriptionCommand, SubscriptionPlan>();

            // Mapping from UpdateRateCommand to Rate
            CreateMap<UpdateUserSubscriptionCommand, SubscriptionPlan>();

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
