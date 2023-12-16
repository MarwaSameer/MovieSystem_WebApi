using MoviesSystem.Domain.Entities;
using MovieSystem.Application.IServices;
using MovieSystem.Infrastructure.Repositories.SubscripsionPlanRepository;

namespace MovieSystem.Application.Services
{
    public class SubscriptionPlanService : ISubscriptionPlanService
    {
        #region CTOR
        private readonly ISubscriptionPlanRepository _subscripsionPlanRepository;
        public SubscriptionPlanService(ISubscriptionPlanRepository subscripsionPlanRepository)
        {
            _subscripsionPlanRepository = subscripsionPlanRepository;
        }
        #endregion

        public async Task<string> AddSubscriptionPlanAsync(SubscriptionPlan Dto)
        {
            return await _subscripsionPlanRepository.CreateAsync(Dto);
        }

        public async Task<string> DeleteSubscriptionPlanAsync(int SubscripsionPlanId)
        {
            return await _subscripsionPlanRepository.DeleteAsync(SubscripsionPlanId);
        }

        public async Task<IEnumerable<SubscriptionPlan>> GetAllSubscriptionPlansAsync()
        {
            return await _subscripsionPlanRepository.GetAllAsync();
        }

        public async Task<SubscriptionPlan> GetSubscriptionPlanByIdAsync(int SubscripsionPlanId)
        {
            return await _subscripsionPlanRepository.GetByIdAsync(SubscripsionPlanId);
        }

        public async Task<SubscriptionPlan> UpdateSubscriptionPlanAsync(SubscriptionPlan Dto)
        {
            return await _subscripsionPlanRepository.UpdateAsync(Dto);
        }
    }
}
