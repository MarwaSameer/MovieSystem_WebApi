using MoviesSystem.Domain.Entities;

namespace MovieSystem.Application.IServices
{
    public interface ILikeService
    {
        Task<IEnumerable<Like>> GetAllLikesAsync();
        Task<Like> GetLikeByIdAsync(int id);

        Task<string> AddLikeAsync(Like Dto);
        Task<Like> UpdateLikeAsync(Like Dto);
        Task<string> DeleteLikeAsync(int id);


        Task<IEnumerable<Like>> GetLikesByMovieIdAsync(int MovieId);
        //GetRatesByMovieIdQuery
        Task<IEnumerable<Like>> GetLikesByUserIdAsync(string UserId);

        //GetRatesByUserIdQuery
        Task<Like> GetLikeByUserAndMovieIdsAsync(int MovieId, string UserId);
        //GetRateByUserAndMovieIdsQuery
    }
}
