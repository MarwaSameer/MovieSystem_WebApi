using MediatR;
using MovieSystem.Application.Bases;
using MovieSystem.Application.Feature.Rates.Queries.Response;

namespace MovieSystem.Application.Feature.Rates.Queries.Models
{
    public class GetRatesByMovieIdQuery : IRequest<Response<IEnumerable<GetRateListResponse>>>
    {
        public int MovieId { get; set; }
    }
}
