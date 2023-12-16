using MediatR;
using MoviesSystem.Domain.Entities;

namespace MovieSystem.Application.Feature.Categories.Commands.Models
{
    public class UpdateCategoryCommand : IRequest<Category>
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
