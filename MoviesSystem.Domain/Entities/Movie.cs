using System.ComponentModel.DataAnnotations;

namespace MoviesSystem.Domain.Entities
{
    public class Movie : BaseEntity
    {

        //public int MovieId { get; set; }

        [StringLength(50)]
        public string MovieName { get; set; } = null!;
        [StringLength(500)]
        public string MovieDescription { get; set; } = null!;
        public byte[]? MovieImage { get; set; } = null!;
        // public Uri VideoUrl { get; set; } = null!;
        public string VideoUrl { get; set; } = null!;
        public string? TrillerUrl { get; set; } = null!;
        public string Country { get; set; } = null!;
        public int Duration { get; set; } // Minutes
        public int ProductionYear { get; set; }
        public int? RecommendedAge { get; set; }


        // ---------- relations -----------
        public IEnumerable<Review>? Reviews { get; set; }
        public IEnumerable<MovieCategory>? MovieCategorys { get; set; }
        public IEnumerable<Rate>? Rates { get; set; }
        public IEnumerable<Like>? Likes { get; set; }

        public int TypeId { get; set; }
        public MovieType? MovieType { get; set; }
    }
}