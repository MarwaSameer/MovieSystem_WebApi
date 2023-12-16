using MediatR;
using MovieSystem.Application.Feature.UserSubsss.Queries.Response;

namespace MovieSystem.Application.Feature.UserSubsss.Queries.Models
{
    public class GetUserSubscriptionByIdQuery : IRequest<GetUserSubscriptionListResponse>
    {
        public int Id { get; set; }
    }
}
