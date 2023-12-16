using Microsoft.Extensions.DependencyInjection;
using MovieSystem.Infrastructure.Generic;
using MovieSystem.Infrastructure.Repositories.CategoryRepositories;
using MovieSystem.Infrastructure.Repositories.LikeRepository;
using MovieSystem.Infrastructure.Repositories.MovieCategoryRepositories;
using MovieSystem.Infrastructure.Repositories.MovieRepositories.MovieRepository;
using MovieSystem.Infrastructure.Repositories.MovieRepository;
using MovieSystem.Infrastructure.Repositories.RateRepository;
using MovieSystem.Infrastructure.Repositories.ReviewRepository;
using MovieSystem.Infrastructure.Repositories.SubscripsionPlanRepository;
using MovieSystem.Infrastructure.Repositories.UserSubscriptionRepositories;
using MovieSystem.Infrastructure.Repositories.UserSubscriptionRepository;

namespace MovieSystem.Infrastructure
{
    public static class InfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IMovieRepository, MovieRepository>();

            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IRateRepository, RateRepository>();
            services.AddTransient<ILikeRepository, LikeRepository>();
            services.AddTransient<IMovieCategoryRepository, MovieCategoryRepository>();
            services.AddTransient<IReviewRepository, ReviewRepository>();
            services.AddTransient<ISubscriptionPlanRepository, SubscriptionPlanRepository>();
            services.AddTransient<IUserSubscriptionRepository, UserSubscriptionRepository>();
            return services;
        }
    }
}
