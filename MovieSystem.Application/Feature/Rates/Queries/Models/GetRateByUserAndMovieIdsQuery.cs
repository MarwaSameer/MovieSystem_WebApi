using MediatR;
using MovieSystem.Application.Bases;
using MovieSystem.Application.Feature.Rates.Queries.Response;

namespace MovieSystem.Application.Feature.Rates.Queries.Models
{
    public class GetRateByUserAndMovieIdsQuery : IRequest<Response<GetRateListResponse>>
    {
        public string UserId { get; set; }
        public int MovieId { get; set; }
    }
}
