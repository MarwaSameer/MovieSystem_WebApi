using MediatR;
using MovieSystem.Application.Bases;
using MovieSystem.Application.Feature.Likes.Queries.Response;

namespace MovieSystem.Application.Feature.Likes.Queries.Models
{
    public class GetLikesByUserIdQuery : IRequest<Response<IEnumerable<GetLikeListResponse>>>
    {
        public string UserId { get; set; }
    }
}
