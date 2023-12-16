

using AutoMapper;
using MediatR;
using MoviesSystem.Domain.Entities;
using MovieSystem.Application.Feature.SubScripPlan.Commands.Models;
using MovieSystem.Application.IServices;

namespace MovieSystem.Application.Feature.SubScripPlan.Commands.Handlers
{
    public class SubscriptionPlanCommandHandler : IRequestHandler<AddSubscriptionPlanCommand, string>,
         IRequestHandler<UpdateSubscriptionPlanCommand, SubscriptionPlan>,
        IRequestHandler<DeleteSubscriptionPlanCommand, string>
    {
        private ISubscriptionPlanService _subscriptionPlanService;
        private IMapper _mapper;

        public SubscriptionPlanCommandHandler(ISubscriptionPlanService Service, IMapper mapper)
        {
            _subscriptionPlanService = Service;
            _mapper = mapper;
        }
        public async Task<string> Handle(AddSubscriptionPlanCommand request, CancellationToken cancellationToken)
        {
            var SubscriptionPlan = _mapper.Map<SubscriptionPlan>(request);


            return await _subscriptionPlanService.AddSubscriptionPlanAsync(SubscriptionPlan);

        }



        public async Task<SubscriptionPlan> Handle(UpdateSubscriptionPlanCommand request, CancellationToken cancellationToken)
        {
            var SubscriptionPlan = _mapper.Map<SubscriptionPlan>(request);


            return await _subscriptionPlanService.UpdateSubscriptionPlanAsync(SubscriptionPlan);
        }

        public async Task<string> Handle(DeleteSubscriptionPlanCommand request, CancellationToken cancellationToken)
        {
            return await _subscriptionPlanService.DeleteSubscriptionPlanAsync(request.SubscriptionPlanId);
        }
    }
}
