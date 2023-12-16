using MediatR;

namespace MovieSystem.Application.Feature.Categories.Commands.Models
{
    public class DeleteCategoryCommand : IRequest<string>
    {
        public int CategoryId { get; set; }
    }
}
