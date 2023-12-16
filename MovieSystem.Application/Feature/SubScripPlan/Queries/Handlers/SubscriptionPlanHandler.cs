

using AutoMapper;
using MediatR;
using MovieSystem.Application.Feature.SubScripPlan.Queries.Models;
using MovieSystem.Application.Feature.SubScripPlan.Queries.Response;
using MovieSystem.Application.IServices;

namespace MovieSystem.Application.Feature.SubScripPlan.Queries.Handlers
{
    public class SubscriptionPlanHandler : IRequestHandler<GetSubscriptionPlanListQuery, IEnumerable<GetSubscriptionPlanListResponse>>,
                                IRequestHandler<GetSubscriptionPlanByIdQuery, GetSubscriptionPlanListResponse>
    {
        private ISubscriptionPlanService _subscriptionPlanService;
        private IMapper _mapper;

        public SubscriptionPlanHandler(ISubscriptionPlanService SubscriptionPlanService, IMapper mapper)
        {
            _subscriptionPlanService = SubscriptionPlanService;
            _mapper = mapper;
        }



        public async Task<IEnumerable<GetSubscriptionPlanListResponse>> Handle(GetSubscriptionPlanListQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _subscriptionPlanService.GetAllSubscriptionPlansAsync();

            return _mapper.Map<IEnumerable<GetSubscriptionPlanListResponse>>(entitiesList);
        }

        public async Task<GetSubscriptionPlanListResponse> Handle(GetSubscriptionPlanByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _subscriptionPlanService.GetSubscriptionPlanByIdAsync(request.SubscriptionPlanId);

            return _mapper.Map<GetSubscriptionPlanListResponse>(entity);
        }
    }
}
