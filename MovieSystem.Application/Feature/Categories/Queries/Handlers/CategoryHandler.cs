using AutoMapper;
using MediatR;
using MovieSystem.Application.Feature.Categories.Queries.Models;
using MovieSystem.Application.Feature.Categories.Queries.Response;
using MovieSystem.Application.IServices;

namespace MovieSystem.Application.Feature.Categories.Queries.Handlers
{
    public class CategoryHandler : IRequestHandler<GetCategoryListQuery, IEnumerable<GetCategoryListResponse>>,
                                IRequestHandler<GetCategoryByIdQuery, GetCategoryListResponse>
    {
        private ICategoryService _categoryService;
        private IMapper _mapper;

        public CategoryHandler(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetCategoryListResponse>> Handle(GetCategoryListQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _categoryService.GetAllCategoriesAsync();

            return _mapper.Map<IEnumerable<GetCategoryListResponse>>(entitiesList);
        }

        public async Task<GetCategoryListResponse> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _categoryService.GetCategoryByIdAsync(request.CategoryId);

            return _mapper.Map<GetCategoryListResponse>(entity);


        }
    }
}
