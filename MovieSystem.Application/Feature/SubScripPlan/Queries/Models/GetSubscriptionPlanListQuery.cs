using MediatR;
using MovieSystem.Application.Feature.SubScripPlan.Queries.Response;

namespace MovieSystem.Application.Feature.SubScripPlan.Queries.Models
{
    public class GetSubscriptionPlanListQuery : IRequest<IEnumerable<GetSubscriptionPlanListResponse>>
    {
    }
}
