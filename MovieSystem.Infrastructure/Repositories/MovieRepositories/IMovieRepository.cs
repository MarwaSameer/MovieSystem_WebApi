using MoviesSystem.Domain.Entities;
using MovieSystem.Infrastructure.Generic;

namespace MovieSystem.Infrastructure.Repositories.MovieRepositories.MovieRepository
{
    public interface IMovieRepository : IGenericRepository<Movie>
    {

        //GetMovies(free)
        Task<IEnumerable<Movie>> GetAllFreeMoviesAsync();
        //GetMovie(paid)
        Task<IEnumerable<Movie>> GetAllPaidMoviesAsync();
    }
}