using Microsoft.EntityFrameworkCore;
using MoviesSystem.Domain.Entities;
using MovieSystem.Infrastructure.Database;
using MovieSystem.Infrastructure.Generic;


namespace MovieSystem.Infrastructure.Repositories.LikeRepository
{
    public class LikeRepository : GenericRepository<Like>, ILikeRepository
    {
        #region CTOR
        private readonly AppDbContext _db;
        public LikeRepository(AppDbContext _appDbContext) : base(_appDbContext)
        {
            _db = _appDbContext;
        }
        #endregion

        public async Task<Like> GetLikeByUserAndMovieIdsAsync(int MovieId, string UserId)
        {
            return await _db.Likes.Where(x => x.UserId == UserId && x.MovieId == MovieId).Include(x => x.Movie).Include(x => x.User).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Like>> GetLikesByMovieIdAsync(int MovieId)
        {
            return await _db.Likes.Where(x => x.MovieId == MovieId).Include(x => x.Movie).Include(x => x.User).ToListAsync();
        }

        public async Task<IEnumerable<Like>> GetLikesByUserIdAsync(string UserId)
        {
            return await _db.Likes.Where(x => x.UserId == UserId).Include(x => x.Movie).Include(x => x.User).ToListAsync();
        }
    }
}
