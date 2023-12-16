using MediatR;
using MoviesSystem.Domain.Entities;

namespace MovieSystem.Application.Feature.UserSubsss.Commands.Models
{
    public class UpdateUserSubscriptionCommand : IRequest<UserSubscription>
    {
        public int Id { get; set; }



        public int PlanId { get; set; }


        public int? Paymentd { get; set; }


    }
}
