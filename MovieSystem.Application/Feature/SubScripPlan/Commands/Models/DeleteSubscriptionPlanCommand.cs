using MediatR;

namespace MovieSystem.Application.Feature.SubScripPlan.Commands.Models
{
    public class DeleteSubscriptionPlanCommand : IRequest<string>
    {
        public int SubscriptionPlanId { get; set; }
    }
}
