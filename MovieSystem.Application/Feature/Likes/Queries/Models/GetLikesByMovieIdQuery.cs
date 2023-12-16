using MediatR;
using MovieSystem.Application.Bases;
using MovieSystem.Application.Feature.Likes.Queries.Response;

namespace MovieSystem.Application.Feature.Likes.Queries.Models
{
    public class GetLikesByMovieIdQuery : IRequest<Response<IEnumerable<GetLikeListResponse>>>
    {
        public int MovieId { get; set; }
    }
}
