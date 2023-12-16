using MoviesSystem.Domain.Entities.Identity;

namespace MoviesSystem.Domain.Entities
{
    public class Review : BaseEntity
    {

        //public int ReviewId { get; set; }

        public string Body { get; set; } = null!;

        // ---------- relations ----------- 
        public string UserId { get; set; } = null!;
        public User? User { get; set; }

        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
    }
}