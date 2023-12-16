using MoviesSystem.Domain.Entities;
using MovieSystem.Infrastructure.Database;
using MovieSystem.Infrastructure.Generic;

namespace MovieSystem.Infrastructure.Repositories.ReviewRepository
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(AppDbContext _appDbContext) : base(_appDbContext)
        {
        }
    }
}
