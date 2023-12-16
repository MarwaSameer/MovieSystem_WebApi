using MediatR;
using MovieSystem.Application.Bases;

namespace MovieSystem.Application.Feature.Likes.Commands.Models
{
    public class AddLikeCommand : IRequest<Response<string>>
    {
        public bool LikeValue { get; set; }

        // ---------- relations -----------
        public string UserId { get; set; } = null!;
        public int MovieId { get; set; }
    }
}
