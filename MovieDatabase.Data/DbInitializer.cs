namespace MovieDatabase.Data
{
    using System.Linq;
    using Entities;


    public static class DbInitializer
    {
        public static void Initialize(MovieDatabaseContext context)
        {
            context.Database.EnsureCreated();

            #region Populate Ratings

            if (context.Ratings.Any())
            {
                return;
            }

            var ratings = new Rating[]
            {
                new Rating {Name = "G"},
                new Rating {Name = "PG"},
                new Rating {Name = "PG-13"},
                new Rating {Name = "R"},
                new Rating {Name = "NC-17"}
            };
            foreach (Rating r in ratings)
            {
                context.Ratings.Add(r);
            }

            context.SaveChanges();

            #endregion

            #region Populate Genres

            if (context.Genres.Any())
            {
                return;
            }

            var genres = new Genre[]
            {

                new Genre {Name = "Action"},
                new Genre {Name = "Adventure"},
                new Genre {Name = "Comedy"},
                new Genre {Name = "Crime"},
                new Genre {Name = "Drama"},
                new Genre {Name = "Fantasy"},
                new Genre {Name = "Historical"},
                new Genre {Name = "Horror"},
                new Genre {Name = "Mystery"},
                new Genre {Name = "Political"},
                new Genre {Name = "Romance"},
                new Genre {Name = "Science fiction"},
                new Genre {Name = "Thriller"},
                new Genre {Name = "Western"}
            };
            foreach (Genre g in genres)
            {
                context.Genres.Add(g);
            }

            context.SaveChanges();

            #endregion

            #region Populate Actors

            

            #endregion
        }
    }
}
