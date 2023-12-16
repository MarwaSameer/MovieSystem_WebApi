using MoviesSystem.Domain.Entities;
using MoviesSystem.Domain.Entities.Identity;
using MovieSystem.Application.DTOs.Authentication;

namespace MovieSystem.Application.IServices
{
    public interface IAuthService
    {

        Task<ResponseDto> SeedRolesAsync();
        Task<AuthResponseModel> RegisterAsync(RegisterDto registerDto);
        Task<AuthResponseModel> LoginAsync(LoginDto loginDto);

        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(string id);


        Task<User> UpdateUserAsync(User Dto);
        Task DeleteUserAsync(string id);


        //GetUserRate(Movie, User)
        Task<Rate> GetRateByUserIdAndMovieIdAsync(int movieId, string userId);

        Task<IEnumerable<Rate>> GetMyRates(string userId);
        Task<IEnumerable<Review>> GetMyReviews(string userId);
        Task<IEnumerable<Like>> GetMyLikes(string userId);


        Task<IEnumerable<SubscriptionPlan>> GetMySubscriptionPlans(string userId);
        Task<bool> ChangePassword(string userId, string password);
        //ChangePassword





    }
}
