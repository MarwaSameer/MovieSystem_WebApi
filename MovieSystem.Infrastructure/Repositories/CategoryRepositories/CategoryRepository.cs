using Microsoft.EntityFrameworkCore;
using MoviesSystem.Domain.Entities;
using MovieSystem.Infrastructure.Database;
using MovieSystem.Infrastructure.Generic;

namespace MovieSystem.Infrastructure.Repositories.CategoryRepositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        #region CTOR
        private DbSet<Category> _category;
        public CategoryRepository(AppDbContext _appDbContext) : base(_appDbContext)
        {
            _category = _appDbContext.Set<Category>();
        }
        #endregion


        public Task<IEnumerable<Category>> GetAllCategoriesByMovieIdAsync(int movieId)
        {
            /*
           
            var table = await _category
                             .Where(c => c.MovieCategorys.SelectMany(a => a.MovieId == movieId) && c.IsDeleted == false)
                             .ToListAsync();
            return table;
        
             */
            throw new NotImplementedException();
        }



    }
}
