using MediatR;
using MovieSystem.Application.Feature.SubScripPlan.Queries.Response;

namespace MovieSystem.Application.Feature.SubScripPlan.Queries.Models
{
    public class GetSubscriptionPlanByIdQuery : IRequest<GetSubscriptionPlanListResponse>
    {
        public int SubscriptionPlanId { get; set; }
    }
}
