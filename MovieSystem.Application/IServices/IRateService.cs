using MoviesSystem.Domain.Entities;

namespace MovieSystem.Application.IServices
{
    public interface IRateService
    {
        Task<IEnumerable<Rate>> GetAllRatesAsync();
        Task<Rate> GetRateByIdAsync(int id);

        Task<string> AddRateAsync(Rate Dto);
        Task<Rate> UpdateRateAsync(Rate Dto);
        Task<string> DeleteRateAsync(int id);
        Task<IEnumerable<Rate>> GetRatesByMovieIdAsync(int MovieId);
        //GetRatesByMovieIdQuery
        Task<IEnumerable<Rate>> GetRatesByUserIdAsync(string UserId);

        //GetRatesByUserIdQuery
        Task<Rate> GetRateByUserAndMovieIdsAsync(int MovieId, string UserId);
        //GetRateByUserAndMovieIdsQuery
    }
}
