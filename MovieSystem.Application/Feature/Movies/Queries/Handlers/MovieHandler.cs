using AutoMapper;
using MediatR;
using MovieSystem.Application.Bases;
using MovieSystem.Application.Feature.Movies.Queries.Models;
using MovieSystem.Application.Feature.Movies.Queries.Response;
using MovieSystem.Application.IServices;

namespace MovieSystem.Application.Feature.Movies.Queries.Handlers
{
    public class MovieHandler : ResponseHandler,
                                IRequestHandler<GetMovieListQuery, Response<IEnumerable<GetMovieListResponse>>>,
                                IRequestHandler<GetMovieByIdQuery, Response<GetMovieListResponse>>,
                                IRequestHandler<GetAllPaidMoviesQuery, Response<IEnumerable<GetMovieResponse>>>,
                                IRequestHandler<GetAllFreeMoviesQuery, Response<IEnumerable<GetMovieResponse>>>
    {
        #region CTOR
        private IMovieService _moviesService;
        private IMapper _mapper;

        public MovieHandler(IMovieService moviesService, IMapper mapper)
        {
            _moviesService = moviesService;
            _mapper = mapper;
        }
        #endregion

        //get all movies
        public async Task<Response<IEnumerable<GetMovieListResponse>>> Handle(GetMovieListQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _moviesService.GetAllMoviesAsync();
            if (entitiesList == null)
            {
                return NotFound<IEnumerable<GetMovieListResponse>>();
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetMovieListResponse>>(entitiesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }

        }

        //Get movie by id
        public async Task<Response<GetMovieListResponse>> Handle(GetMovieByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _moviesService.GetMovieByIdAsync(request.MovieId);

            if (entity == null)
            {
                return NotFound<GetMovieListResponse>("Sorry, There is no data to display!");
            }
            else
            {
                var entityMapped = _mapper.Map<GetMovieListResponse>(entity);


                return Success(entityMapped);
            }
        }

        //get all paid movies
        public async Task<Response<IEnumerable<GetMovieResponse>>> Handle(GetAllPaidMoviesQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _moviesService.GetAllPaidMoviesAsync();
            if (entitiesList == null)
            {
                return NotFound<IEnumerable<GetMovieResponse>>("Sorry, There is no data to display!");
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetMovieResponse>>(entitiesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }
        }

        // get all free movies
        public async Task<Response<IEnumerable<GetMovieResponse>>> Handle(GetAllFreeMoviesQuery request, CancellationToken cancellationToken)
        {
            var entitiesList = await _moviesService.GetAllMoviesAsync();
            if (entitiesList == null)
            {
                return NotFound<IEnumerable<GetMovieResponse>>("Sorry, There is no data to display!");
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetMovieResponse>>(entitiesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }
        }
    }
}
