namespace MovieSystem.Application.Feature.UserSubsss.Queries.Response
{
    public class GetUserSubscriptionListResponse
    {
        public string UserId { get; set; } = null!;


        public int PlanId { get; set; }


        public int? Paymentd { get; set; }

    }
}
