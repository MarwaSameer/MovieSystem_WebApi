using MediatR;
using MoviesSystem.Domain.Entities;
using MovieSystem.Application.Bases;

namespace MovieSystem.Application.Feature.Categories.Commands.Models
{
    public class UpdateLikeCommand : IRequest<Response<Like>>
    {
        public int Id { get; set; }
        public bool LikeValue { get; set; }

        // ---------- relations -----------
        public string UserId { get; set; } = null!;
        public int MovieId { get; set; }
    }
}
