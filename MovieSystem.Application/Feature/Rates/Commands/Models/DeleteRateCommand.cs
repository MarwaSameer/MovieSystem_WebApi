using MediatR;
using MovieSystem.Application.Bases;

namespace MovieSystem.Application.Feature.Rates.Commands.Models
{
    public class DeleteRateCommand : IRequest<Response<string>>
    {
        public int RateId { get; set; }
    }
}
