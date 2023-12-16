using MediatR;
using MovieSystem.Application.Bases;
using MovieSystem.Application.Feature.Movies.Queries.Response;

namespace MovieSystem.Application.Feature.Movies.Queries.Models
{
    public class GetAllFreeMoviesQuery : IRequest<Response<IEnumerable<GetMovieResponse>>>
    {
    }
}
