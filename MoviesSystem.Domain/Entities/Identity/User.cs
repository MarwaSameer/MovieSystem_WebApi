
using Microsoft.AspNetCore.Identity;

namespace MoviesSystem.Domain.Entities.Identity
{
    public class User : IdentityUser
    {

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;


        // ---------- relations -----------
        public ICollection<SubscriptionPlan>? Subscriptions { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<Rate>? Rates { get; set; }
        public ICollection<Like>? Likes { get; set; }

    }
}
