using MediatR;
using MovieSystem.Application.Bases;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieSystem.Application.Feature.Rates.Commands.Models
{
    public class AddRateCommand : IRequest<Response<string>>
    {
        [Range(1, 5)]
        public int RateValue { get; set; }

        // ---------- relations -----------
        public string UserId { get; set; } = null!;
        [ForeignKey("UserId")]


        public int MovieId { get; set; }

    }
}
