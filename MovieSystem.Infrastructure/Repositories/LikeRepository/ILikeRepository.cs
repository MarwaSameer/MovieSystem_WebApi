using MoviesSystem.Domain.Entities;
using MovieSystem.Infrastructure.Generic;


namespace MovieSystem.Infrastructure.Repositories.LikeRepository
{
    public interface ILikeRepository : IGenericRepository<Like>
    {
        Task<IEnumerable<Like>> GetLikesByMovieIdAsync(int MovieId);
        //GetRatesByMovieIdQuery
        Task<IEnumerable<Like>> GetLikesByUserIdAsync(string UserId);

        //GetRatesByUserIdQuery
        Task<Like> GetLikeByUserAndMovieIdsAsync(int MovieId, string UserId);
        //GetRateByUserAndMovieIdsQuery
    }
}
