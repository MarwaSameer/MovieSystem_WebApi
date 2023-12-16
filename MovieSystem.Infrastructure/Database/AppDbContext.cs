using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoviesSystem.Domain.Entities;
using MoviesSystem.Domain.Entities.Identity;

namespace MovieSystem.Infrastructure.Database
{
    public class AppDbContext : IdentityDbContext<User>
    {
        #region DbSets
        public DbSet<Movie> Movies { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Review> Reviews { get; set; } = null!;
        public DbSet<Rate> Rates { get; set; } = null!;
        public DbSet<Like> Likes { get; set; } = null!;
        public DbSet<MovieType> MovieTypes { get; set; } = null!;
        public DbSet<MovieCategory> MovieCategorys { get; set; } = null!;
        public DbSet<Payment> Payments { get; set; } = null!;
        public DbSet<SubscriptionPlan> SubscripsionPlans { get; set; } = null!;
        public DbSet<UserSubscription> UserSubscriptions { get; set; } = null!;

        #endregion

        public AppDbContext() { }
        public AppDbContext(DbContextOptions options) : base(options) { }

        override protected void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Data Seeding

            builder.Entity<MovieType>(builder =>
            {
                builder.HasData(new MovieType { MovieTypeId = 1, MovieTypeName = "Free" });
                builder.HasData(new MovieType { MovieTypeId = 2, MovieTypeName = "Paid" });
            });

            builder.Entity<Category>(builder =>
            {
                builder.HasData(new Category { Id = 1, Name = "Cartoon", Description = "Cartoon Category" });
                builder.HasData(new Category { Id = 2, Name = "Action", Description = "Action Category" });
                builder.HasData(new Category { Id = 3, Name = "Adventure", Description = "Adventure Category" });
                builder.HasData(new Category { Id = 4, Name = "Comedy", Description = "Comedy Category" });
                builder.HasData(new Category { Id = 5, Name = "Horror", Description = "Horror Category" });
                builder.HasData(new Category { Id = 6, Name = "Romance", Description = "Romance Category" });
                builder.HasData(new Category { Id = 7, Name = "Science fiction", Description = "Science fiction Category" });
                builder.HasData(new Category { Id = 8, Name = "Fantasy", Description = "Fantasy Category" });
                builder.HasData(new Category { Id = 9, Name = "Historical", Description = "Historical Category" });
                builder.HasData(new Category { Id = 10, Name = "Musical", Description = "Musical Category" });
                builder.HasData(new Category { Id = 11, Name = "Drama", Description = "Drama Category" });
            });

            builder.Entity<Movie>(builder =>
            {
                builder.HasData(new Movie { Id = 1, MovieName = "UP", MovieDescription = "UP Pabbrt 1 Cartoon", VideoUrl = "www.youtube.com", Country = "USA", Duration = 120, ProductionYear = 2006, RecommendedAge = 10, TypeId = 1 });
                builder.HasData(new Movie { Id = 2, MovieName = "Zootopia", MovieDescription = "Zootopia Part 1 Cartoon", VideoUrl = "www.youtube.com", Country = "USA", Duration = 120, ProductionYear = 2010, RecommendedAge = 10, TypeId = 2 });
                builder.HasData(new Movie { Id = 3, MovieName = "Sing 1", MovieDescription = "Sing Part 1 Cartoon", VideoUrl = "www.youtube.com", Country = "USA", Duration = 120, ProductionYear = 2015, RecommendedAge = 12, TypeId = 1 });
                builder.HasData(new Movie { Id = 4, MovieName = "Sing 2", MovieDescription = "Sing Part 2 Cartoon", VideoUrl = "www.youtube.com", Country = "USA", Duration = 120, ProductionYear = 2015, RecommendedAge = 12, TypeId = 1 });
                builder.HasData(new Movie { Id = 5, MovieName = "Titanic", MovieDescription = "Titanic Part 1 Movie", VideoUrl = "www.youtube.com", Country = "USA", Duration = 120, ProductionYear = 2000, RecommendedAge = 15, TypeId = 2 });
            });

            builder.Entity<MovieCategory>(builder =>
            {
                builder.HasData(new MovieCategory { MovieId = 1, CategoryId = 1 });
                builder.HasData(new MovieCategory { MovieId = 1, CategoryId = 3 });

                builder.HasData(new MovieCategory { MovieId = 2, CategoryId = 1 });
                builder.HasData(new MovieCategory { MovieId = 2, CategoryId = 2 });
                builder.HasData(new MovieCategory { MovieId = 2, CategoryId = 3 });
                builder.HasData(new MovieCategory { MovieId = 2, CategoryId = 11 });

                builder.HasData(new MovieCategory { MovieId = 3, CategoryId = 1 });
                builder.HasData(new MovieCategory { MovieId = 3, CategoryId = 11 });
                builder.HasData(new MovieCategory { MovieId = 3, CategoryId = 6 });

                builder.HasData(new MovieCategory { MovieId = 4, CategoryId = 1 });
                builder.HasData(new MovieCategory { MovieId = 4, CategoryId = 11 });
                builder.HasData(new MovieCategory { MovieId = 4, CategoryId = 6 });

                builder.HasData(new MovieCategory { MovieId = 5, CategoryId = 2 });
                builder.HasData(new MovieCategory { MovieId = 5, CategoryId = 11 });
                builder.HasData(new MovieCategory { MovieId = 5, CategoryId = 6 });
            });

            /*
            builder.Entity<Review>(builder =>
            {
                builder.HasData(new Review { });
                builder.HasData(new Review { });
                builder.HasData(new Review { });
            });

            builder.Entity<Rate>(builder =>
            {
                builder.HasData(new Rate { });
                builder.HasData(new Rate { });
                builder.HasData(new Rate { });
            });

            builder.Entity<Like>(builder =>
            {
                builder.HasData(new Like { });
                builder.HasData(new Like { });
                builder.HasData(new Like { });
            });
             
            builder.Entity<Payment>(builder =>
            {
                builder.HasData(new Payment { });
                builder.HasData(new Payment { });
                builder.HasData(new Payment { });
            });

            builder.Entity<SubscripsionPlan>(builder =>
            {
                builder.HasData(new SubscripsionPlan { });
                builder.HasData(new SubscripsionPlan { });
                builder.HasData(new SubscripsionPlan { });
            });

            builder.Entity<UserSubscription>(builder =>
            {
                builder.HasData(new UserSubscription { });
                builder.HasData(new UserSubscription { });
                builder.HasData(new UserSubscription { });
            });
            */

            #endregion

            // Review table
            builder.Entity<Review>(builder =>
            {
                builder.HasOne(r => r.User)
                    .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.NoAction);

                // builder
                // .HasIndex(r => new { r.UserId, r.MovieId })
                // .IsUnique();
            });

            // Rate table
            builder.Entity<Rate>(builder =>
            {
                builder.HasOne(r => r.User)
                    .WithMany(u => u.Rates)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.NoAction);

                builder
                .HasIndex(r => new { r.UserId, r.MovieId })
                .IsUnique();
            });

            // Like table
            builder.Entity<Like>(builder =>
            {
                builder.HasOne(r => r.User)
                    .WithMany(u => u.Likes)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.NoAction);

                builder
                .HasIndex(r => new { r.UserId, r.MovieId })
                .IsUnique();
            });

            //MovieCategory Table
            builder.Entity<MovieCategory>(builder =>
            {
                builder
                .HasKey(r => new { r.MovieId, r.CategoryId });

                builder
               .HasIndex(r => new { r.MovieId, r.CategoryId })
               .IsUnique();

                builder
                .HasOne(r => r.Movie)
                .WithMany(u => u.MovieCategorys)
                .HasForeignKey(r => r.MovieId);

                builder
                .HasOne(r => r.Category)
                .WithMany(u => u.MovieCategorys)
                .HasForeignKey(r => r.CategoryId);
            });

        }
    }
}




