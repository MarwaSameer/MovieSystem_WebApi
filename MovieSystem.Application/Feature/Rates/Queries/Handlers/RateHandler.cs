using AutoMapper;
using MediatR;
using MovieSystem.Application.Bases;
using MovieSystem.Application.Feature.Rates.Queries.Models;
using MovieSystem.Application.Feature.Rates.Queries.Response;
using MovieSystem.Application.IServices;

namespace MovieSystem.Application.Feature.Rates.Queries.Handlers
{
    public class RateHandler : ResponseHandler, IRequestHandler<GetRateListQuery, Response<IEnumerable<GetRateListResponse>>>,
                                IRequestHandler<GetRateByIdQuery, Response<GetRateListResponse>>,
                                 IRequestHandler<GetRatesByMovieIdQuery, Response<IEnumerable<GetRateListResponse>>>,
                                IRequestHandler<GetRateByUserAndMovieIdsQuery, Response<GetRateListResponse>>,
                                 IRequestHandler<GetRatesByUserIdQuery, Response<IEnumerable<GetRateListResponse>>>
    {
        private IRateService _RateService;
        private IMapper _mapper;

        public RateHandler(IRateService categoryService, IMapper mapper)
        {
            _RateService = categoryService;
            _mapper = mapper;
        }

        public async Task<Response<IEnumerable<GetRateListResponse>>> Handle(GetRateListQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _RateService.GetAllRatesAsync();
            if (entitiesList == null)
            {
                return NotFound<IEnumerable<GetRateListResponse>>();
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetRateListResponse>>(entitiesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }

        }

        public async Task<Response<GetRateListResponse>> Handle(GetRateByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _RateService.GetRateByIdAsync(request.RateId);

            var data = _mapper.Map<GetRateListResponse>(entity);
            return new Response<GetRateListResponse>(data);

        }

        public async Task<Response<IEnumerable<GetRateListResponse>>> Handle(GetRatesByUserIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _RateService.GetRatesByUserIdAsync(request.UserId);

            var data = _mapper.Map<IEnumerable<GetRateListResponse>>(entity);
            return new Response<IEnumerable<GetRateListResponse>>(data);
        }


        public async Task<Response<GetRateListResponse>> Handle(GetRateByUserAndMovieIdsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _RateService.GetRateByUserAndMovieIdsAsync(request.MovieId, request.UserId);

            var data = _mapper.Map<GetRateListResponse>(entity);
            return new Response<GetRateListResponse>(data);
        }

        public async Task<Response<IEnumerable<GetRateListResponse>>> Handle(GetRatesByMovieIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _RateService.GetRatesByMovieIdAsync(request.MovieId);



            // Utilisez le mapper pour mapper les entités Rate à GetRateListResponse.
            var data = _mapper.Map<IEnumerable<GetRateListResponse>>(entity);

            return new Response<IEnumerable<GetRateListResponse>>(data);
        }
    }
}
