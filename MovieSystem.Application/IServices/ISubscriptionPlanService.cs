using MoviesSystem.Domain.Entities;

namespace MovieSystem.Application.IServices
{
    public interface ISubscriptionPlanService
    {
        Task<IEnumerable<SubscriptionPlan>> GetAllSubscriptionPlansAsync();

        Task<SubscriptionPlan> GetSubscriptionPlanByIdAsync(int SubscripsionPlanId);//WatchMovie 
        Task<string> AddSubscriptionPlanAsync(SubscriptionPlan Dto);
        Task<SubscriptionPlan> UpdateSubscriptionPlanAsync(SubscriptionPlan Dto);
        Task<string> DeleteSubscriptionPlanAsync(int SubscripsionPlanId);


    }
}
