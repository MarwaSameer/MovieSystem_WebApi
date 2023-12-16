using MoviesSystem.Domain.Entities;
using MovieSystem.Application.IServices;
using MovieSystem.Infrastructure.Repositories.LikeRepository;

namespace MovieSystem.Application.Services
{
    public class LikeService : ILikeService
    {
        #region CTOR
        private readonly ILikeRepository _likeRepository;
        public LikeService(ILikeRepository likeRepository)
        {
            _likeRepository = likeRepository;
        }
        #endregion

        public async Task<IEnumerable<Like>> GetAllLikesAsync()
        {
            return await _likeRepository.GetAllAsync(r => r.Movie, r => r.User);
        }

        public async Task<Like> GetLikeByIdAsync(int id)
        {
            return await _likeRepository.GetByIdAsync(id, r => r.Movie, r => r.User);
        }

        public async Task<string> AddLikeAsync(Like Dto)
        {
            return await _likeRepository.CreateAsync(Dto);
        }

        public async Task<Like> UpdateLikeAsync(Like Dto)
        {
            return await _likeRepository.UpdateAsync(Dto);
        }

        public async Task<string> DeleteLikeAsync(int id)
        {
            return await _likeRepository.DeleteAsync(id);
        }
        //////////////////////////
        public async Task<Like> GetLikeByUserAndMovieIdsAsync(int MovieId, string UserId)
        {
            return await _likeRepository.GetLikeByUserAndMovieIdsAsync(MovieId, UserId);
        }

        public async Task<IEnumerable<Like>> GetLikesByMovieIdAsync(int MovieId)
        {
            return await _likeRepository.GetLikesByMovieIdAsync(MovieId);
        }

        public async Task<IEnumerable<Like>> GetLikesByUserIdAsync(string UserId)
        {
            return await _likeRepository.GetLikesByUserIdAsync(UserId);

        }
    }
}
