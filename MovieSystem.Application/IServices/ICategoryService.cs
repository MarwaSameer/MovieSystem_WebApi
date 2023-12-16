using MoviesSystem.Domain.Entities;

namespace MovieSystem.Application.IServices
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<Category> GetCategoryByIdAsync(int id);

        Task<string> AddCategoryAsync(Category Dto);
        Task<Category> UpdateCategoryAsync(Category Dto);
        Task<string> DeleteCategoryAsync(int id);
    }
}
