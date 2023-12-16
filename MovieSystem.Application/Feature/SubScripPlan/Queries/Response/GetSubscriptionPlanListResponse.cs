namespace MovieSystem.Application.Feature.SubScripPlan.Queries.Response
{
    public class GetSubscriptionPlanListResponse
    {
        public string Name { get; set; } = null!;
        public int Duration { get; set; }  // days
        public float Price { get; set; }
    }
}
