using MediatR;
using MovieSystem.Application.Bases;
using MovieSystem.Application.Feature.Likes.Queries.Response;

namespace MovieSystem.Application.Feature.Likes.Queries.Models
{
    public class GetLikeByIdQuery : IRequest<Response<GetLikeListResponse>>
    {
        public int LikeId { get; set; }
    }
}
