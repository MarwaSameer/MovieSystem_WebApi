namespace MovieSystem.Application.Feature.Likes.Queries.Response
{
    public class GetLikeListResponse
    {
        public bool LikeValue { get; set; }

        // ---------- relations -----------
        public string UserName { get; set; } = null!;
        public string MovieName { get; set; }
    }
}
