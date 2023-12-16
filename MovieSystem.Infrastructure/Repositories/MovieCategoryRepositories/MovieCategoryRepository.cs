using MoviesSystem.Domain.Entities;
using MovieSystem.Infrastructure.Database;
using MovieSystem.Infrastructure.Generic;

namespace MovieSystem.Infrastructure.Repositories.MovieCategoryRepositories
{
    public class MovieCategoryRepository : GenericRepository<MovieCategory>, IMovieCategoryRepository
    {
        public MovieCategoryRepository(AppDbContext _appDbContext) : base(_appDbContext)
        {

        }
    }
}
