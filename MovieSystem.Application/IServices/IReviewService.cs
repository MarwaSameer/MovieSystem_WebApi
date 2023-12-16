using MoviesSystem.Domain.Entities;

namespace MovieSystem.Application.IServices
{
    public interface IReviewService
    {
        Task<IEnumerable<Review>> GetAllReviewsAsync();
        Task<Review> GetReviewByIdAsync(int id);

        Task<string> AddReviewAsync(Review Dto);
        Task<Review> UpdateReviewAsync(Review Dto);
        Task<string> DeleteReviewAsync(int id);
    }
}
