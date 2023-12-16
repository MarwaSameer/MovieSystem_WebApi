using AutoMapper;
using MediatR;
using MoviesSystem.Domain.Entities;
using MovieSystem.Application.Bases;
using MovieSystem.Application.Feature.Movies.Commands.Models;
using MovieSystem.Application.IServices;

namespace MovieSystem.Application.Feature.Movies.Commands.Handlers
{
    public class MovieCommandHandler : ResponseHandler,
                                       IRequestHandler<AddMovieCommand, Response<string>>,
                                       IRequestHandler<DeleteMovieCommand, Response<string>>,
                                       IRequestHandler<UpdateMovieCommand, Response<Movie>>
    {
        #region CTOR
        private IMovieService _movieService;
        private readonly ICategoryService _categoryService;
        private readonly IMovieCategoryService _movieCategoryService;
        private IMapper _mapper;

        public MovieCommandHandler(IMovieService movieService, ICategoryService categoryService, IMovieCategoryService movieCategoryService, IMapper mapper)
        {
            _movieService = movieService;
            _categoryService = categoryService;
            _movieCategoryService = movieCategoryService;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<string>> Handle(AddMovieCommand request, CancellationToken cancellationToken)
        {
            //upload Image 

            //Check And Add Categories in Bridge Table 

            #region MovieCategory

            //check type id valide or not
            var categories = await _categoryService.GetAllCategoriesAsync();


            bool allIDsExist = request.CategoriesId.All(o => categories.Select(a => a.Id).Contains(o));
            if (!allIDsExist)
            {
                return BadRequest<string>("types id not existe in table type");
            }
            if (request.CategoriesId.Count() == 0)
            {
                return BadRequest<string>("one or more types films is required ");
            }

            // end check type id


            //var film = mapper.Map<Film>(request);
            var movie = _mapper.Map<Movie>(request);

            if (request.CategoriesId != null && request.CategoriesId.Any())
            {
                /*movie.MovieCategorys*/
                var list = new List<MovieCategory>();

                foreach (var typeId in request.CategoriesId)
                {
                    var filmType = new MovieCategory
                    {
                        Movie = movie,
                        CategoryId = typeId
                    };
                    list.Add(filmType);

                }
                movie.MovieCategorys = list;
            }

            #endregion

            //Add Type to Movie
            movie.TypeId = request.MovieTypeId;

            //var movie = _mapper.Map<Movie>(request);

            var result = await _movieService.AddMovieAsync(movie);
            if (result != "success")
            { return BadRequest<string>(""); }
            else { return Created(""); }
        }

        public async Task<Response<Movie>> Handle(UpdateMovieCommand request, CancellationToken cancellationToken)
        {
            var movie = _mapper.Map<Movie>(request);
            var result = await _movieService.UpdateMovieAsync(movie);
            if (result == null) { return BadRequest<Movie>(""); }
            else { return Success<Movie>(result); }
        }

        public async Task<Response<string>> Handle(DeleteMovieCommand request, CancellationToken cancellationToken)
        {
            var result = await _movieService.DeleteMovieAsync(request.MovieId);
            if (result != "success") { return BadRequest<string>(""); }
            else { return Deleted<string>(result); }
        }
    }
}
