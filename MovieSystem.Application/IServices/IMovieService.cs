using MoviesSystem.Domain.Entities;

namespace MovieSystem.Application.IServices
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetAllMoviesAsync();

        Task<Movie> GetMovieByIdAsync(int movieId);//WatchMovie 
        Task<string> AddMovieAsync(Movie Dto);
        Task<Movie> UpdateMovieAsync(Movie Dto);
        Task<string> DeleteMovieAsync(int movieId);

        //GetRates(Movie)
        // Task<IEnumerable<Rate>> GetAllRatesByMovieIdAsync(int movieId);
        //GetMovies(free)
        Task<IEnumerable<Movie>> GetAllFreeMoviesAsync();
        //GetMovie(paid)
        Task<IEnumerable<Movie>> GetAllPaidMoviesAsync();

    }
}
