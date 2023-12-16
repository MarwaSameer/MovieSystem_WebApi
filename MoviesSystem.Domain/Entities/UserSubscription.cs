using MoviesSystem.Domain.Entities.Identity;

namespace MoviesSystem.Domain.Entities
{
    public class UserSubscription : BaseEntity
    {

        //public int UserSubscriptionId { get; set; }
        public bool IsActive { get; set; }


        // ---------- relations -----------
        public string UserId { get; set; } = null!;
        public User? User { get; set; }

        public int PlanId { get; set; }
        public SubscriptionPlan? Plan { get; set; }

        public int Paymentd { get; set; }
        public Payment? Payment { get; set; }
    }
}