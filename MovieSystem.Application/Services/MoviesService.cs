using MoviesSystem.Domain.Entities;
using MovieSystem.Application.IServices;
using MovieSystem.Infrastructure.Repositories.MovieRepositories.MovieRepository;

namespace MovieSystem.Application.Services
{
    public class MoviesService : IMovieService
    {
        #region CTOR
        private readonly IMovieRepository _moviesRepository;
        public MoviesService(IMovieRepository moviesRepository)
        {
            _moviesRepository = moviesRepository;
        }
        #endregion

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            var x = await _moviesRepository.GetAllAsync(m => m.MovieType);
            return x;
        }

        public async Task<Movie> GetMovieByIdAsync(int movieId)
        {
            return await _moviesRepository.GetByIdAsync(movieId, m => m.MovieType);
        }

        public async Task<string> AddMovieAsync(Movie movie)
        {
            return await _moviesRepository.CreateAsync(movie);
        }

        public async Task<string> DeleteMovieAsync(int movieId)
        {
            return await _moviesRepository.DeleteAsync(movieId);
        }

        public async Task<Movie> UpdateMovieAsync(Movie movie)
        {
            return await _moviesRepository.UpdateAsync(movie);
        }

        //public async Task<IEnumerable<Rate>> GetAllRatesByMovieIdAsync(int movieId)
        //{
        //    return await _moviesRepository.GetAllRatesByMovieIdAsync(movieId);
        //}

        public async Task<IEnumerable<Movie>> GetAllFreeMoviesAsync()
        {
            return await _moviesRepository.GetAllFreeMoviesAsync();
        }

        public async Task<IEnumerable<Movie>> GetAllPaidMoviesAsync()
        {
            return await _moviesRepository.GetAllPaidMoviesAsync();
        }
    }
}
