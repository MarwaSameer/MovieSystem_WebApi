using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MoviesSystem.Domain.Entities;
using MoviesSystem.Domain.Entities.Identity;
using MovieSystem.Application.DTOs.Authentication;
using MovieSystem.Application.IServices;
using MovieSystem.Infrastructure.Database;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
namespace MovieSystem.Application.Services
{
    public class AuthRepo : IAuthService
    {
        private readonly AppDbContext _db;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public AuthRepo(AppDbContext db, UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;

        }
        public async Task<ResponseDto> SeedRolesAsync()
        {
            bool isCustomerRoleExists = await _roleManager.RoleExistsAsync("CUSTOMER");
            bool isAdminRoleExists = await _roleManager.RoleExistsAsync("ADMIN");
            bool isSupperAdminRoleExists = await _roleManager.RoleExistsAsync("SUPERADMIN");

            if (isCustomerRoleExists && isAdminRoleExists && isSupperAdminRoleExists)
                return new ResponseDto()
                {
                    IsSuccess = true,
                    DisplayMessage = "Roles Seeding is Already Done"
                };

            //await _roleManager.CreateAsync(new IdentityRole("USER"));
            await _roleManager.CreateAsync(new IdentityRole("ADMIN"));
            await _roleManager.CreateAsync(new IdentityRole("CUSTOMER"));
            await _roleManager.CreateAsync(new IdentityRole("SUPERADMIN"));

            return new ResponseDto()
            {
                IsSuccess = true,
                DisplayMessage = "Role Seeding Done Successfully"
            };
        }




        public async Task<AuthResponseModel> LoginAsync(LoginDto model)
        {
            var authModel = new AuthResponseModel();

            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user is null || !await _userManager.CheckPasswordAsync(user, model.Password))
            {
                authModel.Message = "Email or Password is incorrect!";
                return authModel;
            }

            var jwtSecurityToken = await CreateJwtToken(user);
            var rolesList = await _userManager.GetRolesAsync(user);

            authModel.IsAuthenticated = true;
            authModel.Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            authModel.Email = user.Email;
            authModel.Username = user.UserName;
            authModel.ExpiresOn = jwtSecurityToken.ValidTo;
            authModel.Roles = rolesList.ToList();

            return authModel;

        }
        public async Task<AuthResponseModel> RegisterAsync(RegisterDto model)
        {
            if (await _userManager.FindByEmailAsync(model.Email) is not null)
                return new AuthResponseModel { Message = "Email is already registered!" };

            if (await _userManager.FindByNameAsync(model.UserName) is not null)
                return new AuthResponseModel { Message = "Username is already registered!" };

            var user = new User
            {
                UserName = model.UserName,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                var errors = new StringBuilder();
                foreach (var error in result.Errors)
                    errors.Append($"{error.Description},");

                return new AuthResponseModel { Message = errors.ToString() };
            }

            await _userManager.AddToRoleAsync(user, "CUSTOMER");

            var jwtSecurityToken = await CreateJwtToken(user);

            return new AuthResponseModel
            {
                Email = user.Email,
                ExpiresOn = jwtSecurityToken.ValidTo,
                IsAuthenticated = true,
                Roles = new List<string> { "CUSTOMER" },
                Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
                Username = user.UserName
            };
        }

        private async Task<JwtSecurityToken> CreateJwtToken(User user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var userRoles = await _userManager.GetRolesAsync(user);

            var roleClaims = userRoles.Select(r => new Claim("roles", r)).ToList();

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id)
            }
            .Union(userClaims)
            .Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]!));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                claims: claims,
                expires: DateTime.Now.AddDays(int.Parse(_configuration["JWT:DurationInDays"]!)),
                signingCredentials: signingCredentials);

            return jwtSecurityToken;
        }



        public async Task DeleteUserAsync(string id)
        {
            var result = await _db.Users.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (result != null) { _db.Users.Remove(result); }


        }

        public Task<Rate> GetRateByUserIdAndMovieIdAsync(int movieId, string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _db.Users.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(string id)
        {
            return await _db.Users.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<User> UpdateUserAsync(User Dto)
        {
            _db.Entry(Dto).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return Dto;
        }

        public Task<IEnumerable<Rate>> GetMyRates(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Review>> GetMyReviews(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Like>> GetMyLikes(string userId)
        {
            throw new NotImplementedException();
        }


        public Task<IEnumerable<SubscriptionPlan>> GetMySubscriptionPlans(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ChangePassword(string userId, string password)
        {
            throw new NotImplementedException();
        }
    }
}
