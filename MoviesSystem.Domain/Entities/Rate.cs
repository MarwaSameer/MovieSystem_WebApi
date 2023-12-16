using MoviesSystem.Domain.Entities.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesSystem.Domain.Entities
{
    public class Rate : BaseEntity
    {

        //public int RateId { get; set; }

        [Range(1, 5)]
        public int RateValue { get; set; }

        // ---------- relations -----------
        public string UserId { get; set; } = null!;
        [ForeignKey("UserId")]
        public User? User { get; set; }

        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
    }
}

