using MoviesSystem.Domain.Entities;

namespace MovieSystem.Application.IServices
{
    public interface IMovieCategoryService
    {
        Task<IEnumerable<MovieCategory>> GetAllMovieCategoriesAsync();
        Task<MovieCategory> GetMovieCategoryByIdAsync(int id);

        Task<string> AddMovieCategoryAsync(MovieCategory Dto);
        Task<MovieCategory> UpdateMovieCategoryAsync(MovieCategory Dto);
        Task<string> DeleteMovieCategoryAsync(int id);
    }
}
