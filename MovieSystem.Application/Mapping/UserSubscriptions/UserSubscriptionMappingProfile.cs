using AutoMapper;
using MoviesSystem.Domain.Entities;
using MovieSystem.Application.Feature.UserSubsss.Commands.Models;
using MovieSystem.Application.Feature.UserSubsss.Queries.Response;

namespace MovieSystem.Application.Mapping.UserSubscriptions
{
    public class UserSubscriptionMappingProfile : Profile
    {
        public UserSubscriptionMappingProfile()
        {

            // Mapping from Rate to GetRateListResponse
            CreateMap<UserSubscription, GetUserSubscriptionListResponse>();


            // Mapping from AddRateCommand to Rate
            CreateMap<AddUserSubscriptionCommand, UserSubscription>();

            // Mapping from UpdateRateCommand to Rate
            CreateMap<UpdateUserSubscriptionCommand, UserSubscription>();

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
