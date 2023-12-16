namespace MovieSystem.Application.Feature.Movies.Queries.Response
{
    public class GetMovieListResponse
    {
        public int Id { get; set; }
        public string MovieName { get; set; } = null!;
        public string MovieDescription { get; set; } = null!;
        public int Duration { get; set; } // Minutes 
        public string? MovieTypeName { get; set; }
    }
}
