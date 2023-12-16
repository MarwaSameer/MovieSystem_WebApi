using MediatR;
using MovieSystem.Application.Feature.Categories.Queries.Response;

namespace MovieSystem.Application.Feature.Categories.Queries.Models
{
    public class GetCategoryByIdQuery : IRequest<GetCategoryListResponse>
    {
        public int CategoryId { get; set; }
    }
}
