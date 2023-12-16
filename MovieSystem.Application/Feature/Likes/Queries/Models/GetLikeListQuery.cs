using MediatR;
using MovieSystem.Application.Bases;
using MovieSystem.Application.Feature.Likes.Queries.Response;

namespace MovieSystem.Application.Feature.Likes.Queries.Models
{
    public class GetLikeListQuery : IRequest<Response<IEnumerable<GetLikeListResponse>>>
    {
    }
}
