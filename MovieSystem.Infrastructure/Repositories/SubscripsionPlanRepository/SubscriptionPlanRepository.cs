using MoviesSystem.Domain.Entities;
using MovieSystem.Infrastructure.Database;
using MovieSystem.Infrastructure.Generic;

namespace MovieSystem.Infrastructure.Repositories.SubscripsionPlanRepository
{
    public class SubscriptionPlanRepository : GenericRepository<SubscriptionPlan>, ISubscriptionPlanRepository
    {
        public SubscriptionPlanRepository(AppDbContext _appDbContext) : base(_appDbContext)
        {

        }
    }
}
