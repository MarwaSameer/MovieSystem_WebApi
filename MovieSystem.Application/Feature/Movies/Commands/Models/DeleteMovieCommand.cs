using MediatR;
using MovieSystem.Application.Bases;

namespace MovieSystem.Application.Feature.Movies.Commands.Models
{
    public class DeleteMovieCommand : IRequest<Response<string>>
    {
        public int MovieId { get; set; }

    }
}
