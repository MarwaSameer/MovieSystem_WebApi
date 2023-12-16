using MediatR;

namespace MovieSystem.Application.Feature.Categories.Commands.Models
{
    public class AddCategoryCommand : IRequest<string>
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
