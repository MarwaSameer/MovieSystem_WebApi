using MediatR;
using MovieSystem.Application.Bases;
using MovieSystem.Application.Feature.Rates.Queries.Response;

namespace MovieSystem.Application.Feature.Rates.Queries.Models
{
    public class GetRateListQuery : IRequest<Response<IEnumerable<GetRateListResponse>>>
    {
    }
}
