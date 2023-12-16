using Microsoft.EntityFrameworkCore;
using MoviesSystem.Domain.Entities;
using MovieSystem.Infrastructure.Database;
using MovieSystem.Infrastructure.Generic;

namespace MovieSystem.Infrastructure.Repositories.RateRepository
{
    public class RateRepository : GenericRepository<Rate>, IRateRepository
    {
        private readonly AppDbContext _db;
        public RateRepository(AppDbContext _appDbContext) : base(_appDbContext)
        {
            _db = _appDbContext;
        }

        public async Task<Rate> GetRateByUserAndMovieIdsAsync(int MovieId, string UserId)
        {
            return await _db.Rates.Where(x => x.UserId == UserId && x.MovieId == MovieId).Include(x => x.Movie).Include(x => x.User).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Rate>> GetRatesByMovieIdAsync(int MovieId)
        {
            return await _db.Rates.Where(x => x.MovieId == MovieId).Include(x => x.Movie).Include(x => x.User).ToListAsync();
        }

        public async Task<IEnumerable<Rate>> GetRatesByUserIdAsync(string UserId)
        {
            return await _db.Rates.Where(x => x.UserId == UserId).Include(x => x.Movie).Include(x => x.User).ToListAsync();
        }
    }
}
