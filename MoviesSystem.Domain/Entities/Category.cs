namespace MoviesSystem.Domain.Entities
{
    public class Category : BaseEntity
    {

        //public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        // ---------- relations ----------- 
        public IEnumerable<MovieCategory>? MovieCategorys { get; set; }
    }
}
