using MoviesSystem.Domain.Entities;
using MovieSystem.Infrastructure.Generic;

namespace MovieSystem.Infrastructure.Repositories.RateRepository
{
    public interface IRateRepository : IGenericRepository<Rate>
    {
        Task<IEnumerable<Rate>> GetRatesByMovieIdAsync(int MovieId);
        //GetRatesByMovieIdQuery
        Task<IEnumerable<Rate>> GetRatesByUserIdAsync(string UserId);

        //GetRatesByUserIdQuery
        Task<Rate> GetRateByUserAndMovieIdsAsync(int MovieId, string UserId);
        //GetRateByUserAndMovieIdsQuery
    }
}
