using MediatR;

namespace MovieSystem.Application.Feature.SubScripPlan.Commands.Models
{
    public class AddSubscriptionPlanCommand : IRequest<string>
    {
        public string Name { get; set; } = null!;
        public int Duration { get; set; }  // days
        public float Price { get; set; }
    }
}
