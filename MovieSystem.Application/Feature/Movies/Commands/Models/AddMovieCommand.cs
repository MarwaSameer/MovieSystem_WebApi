#nullable disable
using MediatR;
using MovieSystem.Application.Bases;

namespace MovieSystem.Application.Feature.Movies.Commands.Models
{
    public class AddMovieCommand : IRequest<Response<string>>
    {
        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        public string Country { get; set; }
        public string VideoUrl { get; set; }
        public int Duration { get; set; } // Minutes
        public int ProductionYear { get; set; }
        public int? RecommendedAge { get; set; }
        public int MovieTypeId { get; set; } = 1;
        public ICollection<int>? CategoriesId { get; set; }

    }
}
