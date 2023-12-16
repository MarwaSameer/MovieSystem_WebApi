using Microsoft.EntityFrameworkCore;
using MoviesSystem.Domain.Entities;
using MovieSystem.Infrastructure.Database;
using MovieSystem.Infrastructure.Generic;
using MovieSystem.Infrastructure.Repositories.UserSubscriptionRepositories;

namespace MovieSystem.Infrastructure.Repositories.UserSubscriptionRepository
{
    public class UserSubscriptionRepository : GenericRepository<UserSubscription>, IUserSubscriptionRepository
    {
        private readonly AppDbContext _db;
        public UserSubscriptionRepository(AppDbContext _appDbContext, AppDbContext db) : base(_appDbContext)
        {
            _db = db;
        }
        public UserSubscriptionRepository(AppDbContext _appDbContext) : base(_appDbContext)
        {

        }

        public async Task<IEnumerable<UserSubscription>> GetUserSubscriptionsByUserIdQuery(string UserId)
        {
            return await _db.UserSubscriptions.Where(x => x.UserId == UserId).ToListAsync();
        }
    }
}
