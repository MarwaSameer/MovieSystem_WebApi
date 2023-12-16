using MediatR;
using MovieSystem.Application.Feature.UserSubsss.Queries.Response;

namespace MovieSystem.Application.Feature.UserSubsss.Queries.Models
{
    public class GetUserSubscriptionListQuery : IRequest<IEnumerable<GetUserSubscriptionListResponse>>
    {
    }
}
