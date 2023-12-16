namespace MovieSystem.Application.Feature.Rates.Queries.Response
{
    public class GetRateListResponse
    {
        public int RateValue { get; set; }

        // ---------- relations -----------
        public string UserName { get; set; } = null!;



        public string MovieName { get; set; }
    }
}
