using MoviesSystem.Domain.Entities;
using MovieSystem.Infrastructure.Database;
using MovieSystem.Infrastructure.Generic;
using MovieSystem.Infrastructure.Repositories.PaymentRepositories;

namespace MovieSystem.Infrastructure.Repositories.PaymentRepository
{
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(AppDbContext _appDbContext) : base(_appDbContext)
        {

        }
    }
}
