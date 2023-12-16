using MediatR;
using MoviesSystem.Domain.Entities;
using MovieSystem.Application.Bases;

namespace MovieSystem.Application.Feature.Movies.Commands.Models
{
    public class UpdateMovieCommand : IRequest<Response<Movie>>
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        public string Country { get; set; }
        public string VideoUrl { get; set; }
        public int Duration { get; set; } // Minutes
        public int ProductionYear { get; set; }
        public int? RecommendedAge { get; set; }
        public int? MovieTypeId { get; set; }

    }
}
