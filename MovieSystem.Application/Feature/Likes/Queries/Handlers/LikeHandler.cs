using AutoMapper;
using MediatR;
using MovieSystem.Application.Bases;
using MovieSystem.Application.Feature.Likes.Queries.Models;
using MovieSystem.Application.Feature.Likes.Queries.Response;
using MovieSystem.Application.IServices;

namespace MovieSystem.Application.Feature.Likes.Queries.Handlers
{
    public class LikeHandler : ResponseHandler,
                               IRequestHandler<GetLikeListQuery, Response<IEnumerable<GetLikeListResponse>>>,
                               IRequestHandler<GetLikeByIdQuery, Response<GetLikeListResponse>>,
                               IRequestHandler<GetLikeByUserAndMovieIdsQuery, Response<GetLikeListResponse>>,
                               IRequestHandler<GetLikesByUserIdQuery, Response<IEnumerable<GetLikeListResponse>>>,
                               IRequestHandler<GetLikesByMovieIdQuery, Response<IEnumerable<GetLikeListResponse>>>
    {
        #region CTOR
        private ILikeService _likeService;
        private IMapper _mapper;

        public LikeHandler(ILikeService likeService, IMapper mapper)
        {
            _likeService = likeService;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<IEnumerable<GetLikeListResponse>>> Handle(GetLikeListQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _likeService.GetAllLikesAsync();

            if (entitiesList == null)
            {
                return NotFound<IEnumerable<GetLikeListResponse>>();
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetLikeListResponse>>(entitiesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }
        }

        public async Task<Response<GetLikeListResponse>> Handle(GetLikeByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _likeService.GetLikeByIdAsync(request.LikeId);

            if (entity == null)
            {
                return NotFound<GetLikeListResponse>("Sorry, There is no data to display!");
            }
            else
            {
                var entityMapped = _mapper.Map<GetLikeListResponse>(entity);


                return Success(entityMapped);
            }


        }

        public async Task<Response<GetLikeListResponse>> Handle(GetLikeByUserAndMovieIdsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _likeService.GetLikeByUserAndMovieIdsAsync(request.MovieId, request.UserId);

            if (entity == null)
            {
                return NotFound<GetLikeListResponse>("Sorry, There is no data to display!");
            }
            else
            {
                var entityMapped = _mapper.Map<GetLikeListResponse>(entity);


                return Success(entityMapped);
            }
        }

        public async Task<Response<IEnumerable<GetLikeListResponse>>> Handle(GetLikesByUserIdQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _likeService.GetLikesByUserIdAsync(request.UserId);

            if (entitiesList == null)
            {
                return NotFound<IEnumerable<GetLikeListResponse>>();
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetLikeListResponse>>(entitiesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }
        }

        public async Task<Response<IEnumerable<GetLikeListResponse>>> Handle(GetLikesByMovieIdQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _likeService.GetLikesByMovieIdAsync(request.MovieId);

            if (entitiesList == null)
            {
                return NotFound<IEnumerable<GetLikeListResponse>>();
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetLikeListResponse>>(entitiesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }
        }
    }
}
