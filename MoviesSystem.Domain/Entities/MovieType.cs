namespace MoviesSystem.Domain.Entities
{
    public class MovieType
    {
        public int MovieTypeId { get; set; }
        public string MovieTypeName { get; set; }

        // ---------- relations -----------
        public IEnumerable<Movie>? Movies { get; set; }
    }
}
