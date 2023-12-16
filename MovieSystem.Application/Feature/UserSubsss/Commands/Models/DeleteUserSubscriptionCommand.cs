using MediatR;

namespace MovieSystem.Application.Feature.UserSubsss.Commands.Models
{
    public class DeleteUserSubscriptionCommand : IRequest<string>
    {
        public int Id { get; set; }
    }
}
