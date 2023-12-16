using MoviesSystem.Domain.Entities;
using MovieSystem.Application.IServices;
using MovieSystem.Infrastructure.Repositories.MovieCategoryRepositories;

namespace MovieSystem.Application.Services
{
    public class MovieCategoryService : IMovieCategoryService
    {
        private readonly IMovieCategoryRepository _movieCategoryRepository;
        public MovieCategoryService(IMovieCategoryRepository movieCategoryRepository)
        {
            _movieCategoryRepository = movieCategoryRepository;
        }

        public async Task<string> AddMovieCategoryAsync(MovieCategory Dto)
        {
            return await _movieCategoryRepository.CreateAsync(Dto);
        }

        public Task<string> DeleteMovieCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MovieCategory>> GetAllMovieCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MovieCategory> GetMovieCategoryByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MovieCategory> UpdateMovieCategoryAsync(MovieCategory Dto)
        {
            throw new NotImplementedException();
        }
    }
}
