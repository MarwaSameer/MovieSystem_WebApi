﻿namespace MoviesSystem.Domain.Entities
{
    public class SubscriptionPlan : BaseEntity
    {

        // public int SubscripsionPlanId { get; set; }

        public string Name { get; set; } = null!;
        public int Duration { get; set; }  // days
        public float Price { get; set; }

        // ---------- relations -----------
        public IEnumerable<UserSubscription> Subscriptions { get; set; } = null!;
    }
}
