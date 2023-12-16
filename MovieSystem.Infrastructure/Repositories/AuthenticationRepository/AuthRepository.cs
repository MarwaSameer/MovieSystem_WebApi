using MoviesSystem.Domain.Entities.Identity;
using System.Linq.Expressions;

namespace MovieSystem.Infrastructure.Repositories.AuthenticationRepository
{
    public class AuthRepository : /*GenericRepository<User>,*/ IAuthRepository
    {
        public Task<string> CreateAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync(params Expression<Func<User, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdAsync(int id, Expression<Func<User, object>>[] includes = null)
        {
            throw new NotImplementedException();
        }

        /* public AuthRepository(AppDbContext _appDbContext) : base(_appDbContext)
{

}
*/
        public Task<AuthServiceResponseDto> MakeAdminAsync(UpdatePermissionDto updatePermissionDto)
        {
            throw new NotImplementedException();
        }

        public Task<AuthServiceResponseDto> MakeSuperAdminAsync(UpdatePermissionDto updatePermissionDto)
        {
            throw new NotImplementedException();
        }

        public Task<AuthServiceResponseDto> MakeUserAsync(UpdatePermissionDto updatePermissionDto)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
