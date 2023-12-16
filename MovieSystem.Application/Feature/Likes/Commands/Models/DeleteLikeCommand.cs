using MediatR;
using MovieSystem.Application.Bases;

namespace MovieSystem.Application.Feature.Likes.Commands.Models
{
    public class DeleteLikeCommand : IRequest<Response<string>>
    {
        public int LikeId { get; set; }
    }
}
