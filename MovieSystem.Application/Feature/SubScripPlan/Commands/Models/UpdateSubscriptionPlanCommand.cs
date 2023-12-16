using MediatR;
using MoviesSystem.Domain.Entities;

namespace MovieSystem.Application.Feature.SubScripPlan.Commands.Models
{
    public class UpdateSubscriptionPlanCommand : IRequest<SubscriptionPlan>
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Duration { get; set; }  // days
        public float Price { get; set; }
    }
}
