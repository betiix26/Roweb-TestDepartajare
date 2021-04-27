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
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },
                   new Movie
                   {
                       Title = "Ghostbusters ",
                       ReleaseDate = DateTime.Parse("1984-3-13"),
                       Genre = "Comedy",
                       Price = 8.99M
                   },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M
                    },
                     new Movie
                     {
                         Title = "The Flash",
                         ReleaseDate = DateTime.Parse("2014-10-07"),
                         Genre = "SuperHero Fiction",
                         Price = 13.99M
                     },
                      new Movie
                      {
                          Title = "The Vampire Diaries",
                          ReleaseDate = DateTime.Parse("2009-09-10"),
                          Genre = "Horror Drama",
                          Price = 7.99M
                      },
                       new Movie
                       {
                           Title = "How To Get Away With Murder",
                           ReleaseDate = DateTime.Parse("2014-09-25"),
                           Genre = "Mistery Drama",
                           Price = 12.99M
                       },
                        new Movie
                        {
                            Title = "Supergirl",
                            ReleaseDate = DateTime.Parse("2015-07-08"),
                            Genre = "SuperHero Fiction",
                            Price = 9.99M
                        },
                         new Movie
                         {
                             Title = "The Arrow",
                             ReleaseDate = DateTime.Parse("2012-10-10"),
                             Genre = "SuperHero Fiction",
                             Price = 9.99M
                         },
                          new Movie
                          {
                              Title = "Lucifer",
                              ReleaseDate = DateTime.Parse("2016-01-25"),
                              Genre = "Comedy Drama",
                              Price = 8.99M
                          },
                           new Movie
                           {
                               Title = "Prison Break",
                               ReleaseDate = DateTime.Parse("2005-08-29"),
                               Genre = "Thriller",
                               Price = 9.99M
                           },
                            new Movie
                            {
                                Title = "The Originals",
                                ReleaseDate = DateTime.Parse("2013-10-03"),
                                Genre = "Supernatural Horror",
                                Price = 9.99M
                            },
                             new Movie
                             {
                                 Title = "Legacies",
                                 ReleaseDate = DateTime.Parse("2018-10-25"),
                                 Genre = "Drama Horror",
                                 Price = 9.99M
                             }

                );
                context.SaveChanges();
            }
        }
    }
}