using MoviesSystem.Domain.Entities;

namespace MovieSystem.Application.IServices
{
    public interface IUserSubscriptionSevice
    {

        Task<IEnumerable<UserSubscription>> GetAllUserSubscriptionsAsync();

        Task<UserSubscription> GetUserSubscriptionsByIdAsync(int UserSubscriptionId);//WatchMovie 
        Task<string> AddUserSubscriptionsAsync(UserSubscription Dto);
        Task<UserSubscription> UpdateUserSubscriptionsAsync(UserSubscription Dto);
        Task<string> DeleteUserSubscriptionsAsync(int UserSubscriptionId);
        Task<IEnumerable<UserSubscription>> GetUserSubscriptionsByUserIdQuery(string UserId);
    }
}
