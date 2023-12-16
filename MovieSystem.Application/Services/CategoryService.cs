using MoviesSystem.Domain.Entities;
using MovieSystem.Application.IServices;
using MovieSystem.Infrastructure.Repositories.CategoryRepositories;

namespace MovieSystem.Application.Services
{
    public class CategoryService : ICategoryService
    {
        #region CTOR
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        #endregion

        public async Task<string> AddCategoryAsync(Category catgory)
        {
            return await _categoryRepository.CreateAsync(catgory);
        }

        public async Task<string> DeleteCategoryAsync(int id)
        {
            return await _categoryRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _categoryRepository.GetAllAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await _categoryRepository.GetByIdAsync(id);
        }

        public async Task<Category> UpdateCategoryAsync(Category catgory)
        {
            return await _categoryRepository.UpdateAsync(catgory);
        }
    }
}
