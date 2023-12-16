using MoviesSystem.Domain.Entities;
using MovieSystem.Infrastructure.Generic;


namespace MovieSystem.Infrastructure.Repositories.CategoryRepositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        //Get All Categories by Movie Id
        Task<IEnumerable<Category>> GetAllCategoriesByMovieIdAsync(int movieId);
    }
}
