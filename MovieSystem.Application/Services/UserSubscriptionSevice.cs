using MoviesSystem.Domain.Entities;
using MovieSystem.Application.IServices;
using MovieSystem.Infrastructure.Repositories.UserSubscriptionRepositories;

namespace MovieSystem.Application.Services
{
    public class UserSubscriptionSevice : IUserSubscriptionSevice
    {

        #region CTOR
        private readonly IUserSubscriptionRepository _UserSubscriptionRepository;
        public UserSubscriptionSevice(IUserSubscriptionRepository UserSubscriptionRepository)
        {
            _UserSubscriptionRepository = UserSubscriptionRepository;
        }
        #endregion
        public async Task<string> AddUserSubscriptionsAsync(UserSubscription Dto)
        {
            return await _UserSubscriptionRepository.CreateAsync(Dto);
        }

        public async Task<string> DeleteUserSubscriptionsAsync(int UserSubscriptionId)
        {
            return await _UserSubscriptionRepository.DeleteAsync(UserSubscriptionId);
        }

        public async Task<IEnumerable<UserSubscription>> GetAllUserSubscriptionsAsync()
        {
            return await _UserSubscriptionRepository.GetAllAsync();
        }

        public async Task<UserSubscription> GetUserSubscriptionsByIdAsync(int UserSubscriptionId)
        {
            return await _UserSubscriptionRepository.GetByIdAsync(UserSubscriptionId);
        }

        public async Task<IEnumerable<UserSubscription>> GetUserSubscriptionsByUserIdQuery(string UserId)
        {
            return await _UserSubscriptionRepository.GetUserSubscriptionsByUserIdQuery(UserId);
        }

        public async Task<UserSubscription> UpdateUserSubscriptionsAsync(UserSubscription Dto)
        {
            return await _UserSubscriptionRepository.UpdateAsync(Dto);
        }


    }
}
