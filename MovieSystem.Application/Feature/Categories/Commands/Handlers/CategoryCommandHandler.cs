using AutoMapper;
using MediatR;
using MoviesSystem.Domain.Entities;
using MovieSystem.Application.Feature.Categories.Commands.Models;
using MovieSystem.Application.IServices;

namespace MovieSystem.Application.Feature.Categories.Commands.Handlers
{
    public class CategoryCommandHandler : IRequestHandler<AddCategoryCommand, string>,
         IRequestHandler<UpdateCategoryCommand, Category>,
        IRequestHandler<DeleteCategoryCommand, string>
    {
        private ICategoryService _categoryService;
        private IMapper _mapper;

        public CategoryCommandHandler(ICategoryService Service, IMapper mapper)
        {
            _categoryService = Service;
            _mapper = mapper;
        }
        public async Task<string> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            var Category = _mapper.Map<Category>(request);


            return await _categoryService.AddCategoryAsync(Category);

        }
        public async Task<Category> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var Category = _mapper.Map<Category>(request);


            return await _categoryService.UpdateCategoryAsync(Category);

        }
        public async Task<string> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {



            return await _categoryService.DeleteCategoryAsync(request.CategoryId);

        }
    }
}
