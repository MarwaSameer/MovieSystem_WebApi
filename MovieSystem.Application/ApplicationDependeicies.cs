using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using MovieSystem.Application.Behaviors;
using MovieSystem.Application.IServices;
using MovieSystem.Application.Services;
using System.Reflection;

namespace MovieSystem.Application
{
    public static class ApplicationDependeicies
    {
        public static IServiceCollection AddApplicationDependeicies(this IServiceCollection services)
        {
            services.AddTransient<IAuthService, AuthRepo>();
            services.AddTransient<IRateService, RateService>();

            services.AddTransient<IMovieService, MoviesService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<ILikeService, LikeService>();
            services.AddTransient<IMovieCategoryService, MovieCategoryService>();
            services.AddTransient<ISubscriptionPlanService, SubscriptionPlanService>();
            services.AddTransient<IUserSubscriptionSevice, UserSubscriptionSevice>();


            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            services.AddAutoMapper(Assembly.GetExecutingAssembly());


            // Get Validators
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            // 
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            return services;
        }
    }
}
