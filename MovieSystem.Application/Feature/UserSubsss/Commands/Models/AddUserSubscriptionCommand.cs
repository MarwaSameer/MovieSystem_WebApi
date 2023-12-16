using MediatR;

namespace MovieSystem.Application.Feature.UserSubsss.Commands.Models
{
    public class AddUserSubscriptionCommand : IRequest<string>
    {

        // ---------- relations -----------
        public string UserId { get; set; } = null!;


        public int PlanId { get; set; }


        public int? Paymentd { get; set; }

    }
}
