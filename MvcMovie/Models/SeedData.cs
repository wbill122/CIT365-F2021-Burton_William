using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The RM",
                        ReleaseDate = DateTime.Parse("2011-6-3"),
                        Genre = "Comedy",
                        Price = 7.99M,
                        Rating = "PG",
                        ImagePath = "theRM.jpg"
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-12-14"),
                        Genre = "Drama",
                        Price = 8.99M,
                        Rating = "PG",
                        ImagePath = "OtherSide.jpg"
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2003-09-11"),
                        Genre = "Drama",
                        Price = 9.99M,
                        Rating = "PG-13",
                        ImagePath = "MeetTheMormons.jpg"
                    },

                    new Movie
                    {
                        Title = "Best Two Years",
                        ReleaseDate = DateTime.Parse("2002-01-10"),
                        Genre = "Drama",
                        Price = 8.99M,
                        Rating = "PG",
                        ImagePath = "BestTwo.jpg"
                    },
                     
                    new Movie
                     {
                        Title = "God's Army",
                        ReleaseDate = DateTime.Parse("2004-08-12"),
                        Genre = "Comedy",
                        Price = 3.99M,
                        Rating = "PG",
                        ImagePath = "GodsArmy.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}