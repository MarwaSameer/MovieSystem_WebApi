using MediatR;
using MoviesSystem.Domain.Entities;
using MovieSystem.Application.Bases;
using System.ComponentModel.DataAnnotations;

namespace MovieSystem.Application.Feature.Rates.Commands.Models
{
    public class UpdateRateCommand : IRequest<Response<Rate>>
    {
        public int Id { get; set; }
        [Range(1, 5)]
        public int RateValue { get; set; }

        // ---------- relations -----------
        public string UserId { get; set; } = null!;



        public int MovieId { get; set; }
    }
}
