using MoviesSystem.Domain.Entities.Identity;

namespace MoviesSystem.Domain.Entities
{
    public class Like : BaseEntity
    {

        // public int LikeId { get; set; }
        public bool LikeValue { get; set; }

        // ---------- relations -----------
        public string UserId { get; set; } = null!;
        public User? User { get; set; }
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
    }
}