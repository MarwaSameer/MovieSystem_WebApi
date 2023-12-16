using MediatR;
using MovieSystem.Application.Bases;
using MovieSystem.Application.Feature.Likes.Queries.Response;

namespace MovieSystem.Application.Feature.Likes.Queries.Models
{
    public class GetLikeByUserAndMovieIdsQuery : IRequest<Response<GetLikeListResponse>>
    {
        public int MovieId { get; set; }
        public string UserId { get; set; }
    }
}
