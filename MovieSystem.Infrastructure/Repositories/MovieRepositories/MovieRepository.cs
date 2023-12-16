using Microsoft.EntityFrameworkCore;
using MoviesSystem.Domain.Entities;
using MovieSystem.Infrastructure.Database;
using MovieSystem.Infrastructure.Generic;
using MovieSystem.Infrastructure.Repositories.MovieRepositories.MovieRepository;

namespace MovieSystem.Infrastructure.Repositories.MovieRepository
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {

        #region CTOR
        //private DbSet<Movie> _movies;

        private readonly AppDbContext _db;
        /*
         public MovieRepository(AppDbContext _appDbContext) : base(_appDbConte: base(_appDbContext)xt)
         {
             _movies = _appDbContext.Set<Movie>();
         }*/
        public MovieRepository(AppDbContext _appDbContext) : base(_appDbContext)
        {
            // _movies = _appDbContext.Set<Movie>();
            _db = _appDbContext;
        }
        #endregion

        public async Task<IEnumerable<Movie>> GetAllFreeMoviesAsync()
        {
            var freeMoviesList = await _db.Movies.Where(m => m.TypeId == 1).ToListAsync();
            return freeMoviesList;
        }

        public async Task<IEnumerable<Movie>> GetAllPaidMoviesAsync()
        {
            var paidMoviesList = await _db.Movies.Where(m => m.TypeId == 2).ToListAsync();
            return paidMoviesList;
        }

    }
}
