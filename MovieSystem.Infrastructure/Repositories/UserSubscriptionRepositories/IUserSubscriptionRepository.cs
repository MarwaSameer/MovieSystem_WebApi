using MoviesSystem.Domain.Entities;
using MovieSystem.Infrastructure.Generic;

namespace MovieSystem.Infrastructure.Repositories.UserSubscriptionRepositories
{
    public interface IUserSubscriptionRepository : IGenericRepository<UserSubscription>
    {
        Task<IEnumerable<UserSubscription>> GetUserSubscriptionsByUserIdQuery(string UserId);
    }
}
