using MoviesSystem.Domain.Entities;
using MovieSystem.Application.IServices;
using MovieSystem.Infrastructure.Repositories.RateRepository;

namespace MovieSystem.Application.Services
{
    public class RateService : IRateService
    {

        #region CTOR
        private readonly IRateRepository _rateRepository;
        public RateService(IRateRepository rateRepository)
        {
            _rateRepository = rateRepository;
        }
        #endregion
        public async Task<string> AddRateAsync(Rate Dto)
        {
            return await _rateRepository.CreateAsync(Dto);
        }

        public async Task<string> DeleteRateAsync(int id)
        {
            return await _rateRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Rate>> GetAllRatesAsync()
        {
            return await _rateRepository.GetAllAsync(r => r.Movie, r => r.User);
        }

        public async Task<Rate> GetRateByIdAsync(int id)
        {
            return await _rateRepository.GetByIdAsync(id, r => r.Movie, r => r.User);
        }

        public async Task<Rate> GetRateByUserAndMovieIdsAsync(int MovieId, string UserId)
        {
            return await _rateRepository.GetRateByUserAndMovieIdsAsync(MovieId, UserId);
        }

        public async Task<IEnumerable<Rate>> GetRatesByMovieIdAsync(int MovieId)
        {
            return await _rateRepository.GetRatesByMovieIdAsync(MovieId);
        }

        public async Task<IEnumerable<Rate>> GetRatesByUserIdAsync(string UserId)
        {
            return await _rateRepository.GetRatesByUserIdAsync(UserId);
        }

        public async Task<Rate> UpdateRateAsync(Rate Dto)
        {
            return await _rateRepository.UpdateAsync(Dto);
        }
    }
}
