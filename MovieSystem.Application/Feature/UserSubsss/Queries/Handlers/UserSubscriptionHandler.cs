

using AutoMapper;
using MediatR;
using MovieSystem.Application.Feature.UserSubsss.Queries.Models;
using MovieSystem.Application.Feature.UserSubsss.Queries.Response;
using MovieSystem.Application.IServices;

namespace MovieSystem.Application.Feature.UserSubsss.Queries.Handlers
{
    public class UserSubscriptionHandler : IRequestHandler<GetUserSubscriptionListQuery, IEnumerable<GetUserSubscriptionListResponse>>,
                                IRequestHandler<GetUserSubscriptionByIdQuery, GetUserSubscriptionListResponse>
    {
        private IUserSubscriptionSevice _usersubscriptionService;
        private IMapper _mapper;

        public UserSubscriptionHandler(IUserSubscriptionSevice SubscriptionPlanService, IMapper mapper)
        {
            _usersubscriptionService = SubscriptionPlanService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetUserSubscriptionListResponse>> Handle(GetUserSubscriptionListQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _usersubscriptionService.GetAllUserSubscriptionsAsync();

            return _mapper.Map<IEnumerable<GetUserSubscriptionListResponse>>(entitiesList);
        }



        public async Task<GetUserSubscriptionListResponse> Handle(GetUserSubscriptionByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _usersubscriptionService.GetUserSubscriptionsByIdAsync(request.Id);

            return _mapper.Map<GetUserSubscriptionListResponse>(entity);
        }
    }
}
