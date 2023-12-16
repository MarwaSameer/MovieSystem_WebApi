using MoviesSystem.Domain.Entities;
using MovieSystem.Application.IServices;
using MovieSystem.Infrastructure.Repositories.ReviewRepository;

namespace MovieSystem.Application.Services
{
    public class ReviewService : IReviewService
    {
        #region CTOR
        private readonly IReviewRepository _reviewRepository;
        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }
        #endregion

        public async Task<string> AddReviewAsync(Review Dto)
        {
            return await _reviewRepository.CreateAsync(Dto);
        }

        public async Task<string> DeleteReviewAsync(int id)
        {
            return await _reviewRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Review>> GetAllReviewsAsync()
        {
            return await _reviewRepository.GetAllAsync();
        }

        public async Task<Review> GetReviewByIdAsync(int id)
        {
            return await _reviewRepository.GetByIdAsync(id);
        }

        public async Task<Review> UpdateReviewAsync(Review Dto)
        {
            return await _reviewRepository.UpdateAsync(Dto);
        }
    }
}
