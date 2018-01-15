namespace MovieDatabase.Data
{
    using System;
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
                new Rating {Name = "G",},
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

            var actors = new Actor[]
            {

                new Actor {FirstName = "Karen",MiddleName = "Sheila",LastName = "Gillan",BirthDate = new DateTime(1987,9,28),City = "Inverness",Country = "Scotland",Region = "UK",DeceasedDate = null},
                new Actor {FirstName = "Cristin",MiddleName = "",LastName = "Milioti",BirthDate = new DateTime(1985,8,16),City = "Cherry Hill",Country = "New Jersey",Region = "USA",DeceasedDate = null},
                new Actor {FirstName = "Ana",MiddleName = "Celia ",LastName = "de Armas",BirthDate = new DateTime(1988,4,30),City = "Havana",Country = "Cuba",Region = "",DeceasedDate = null},
                new Actor {FirstName = "Daisy",MiddleName = "Jazz Isobel",LastName = "Ridley",BirthDate = new DateTime(1992,4,10),City = "London",Country = "England",Region = "UK",DeceasedDate = null},
                new Actor {FirstName = "Jesse",MiddleName = "",LastName = "Plemons",BirthDate = new DateTime(1988,4,2),City = "Dallas",Country = "Texas",Region = "USA",DeceasedDate = null},
                new Actor {FirstName = "Noomi",MiddleName = "",LastName = "Rapace",BirthDate = new DateTime(1979,12,28),City = "Hudiksvall, Gävleborgs län",Country = "Sweden",Region = "",DeceasedDate = null},
                new Actor {FirstName = "Joel",MiddleName = "",LastName = "Edgerton",BirthDate = new DateTime(1974,6,23),City = "Blacktown",Country = "New South Wales",Region = "Australia",DeceasedDate = null},
                new Actor {FirstName = "Tom",MiddleName = "",LastName = "Hardy",BirthDate = new DateTime(1977,9,15),City = "Hammersmith, London",Country = "England",Region = "UK",DeceasedDate = null},
                new Actor {FirstName = "Adam",MiddleName = "Douglas",LastName = "Driver",BirthDate = new DateTime(1983,11,19),City = "San Diego",Country = "California",Region = "USA",DeceasedDate = null},
                new Actor {FirstName = "Chris",MiddleName = "",LastName = "Zylka",BirthDate = new DateTime(1985,5,9),City = "Warren",Country = "Ohio",Region = "USA",DeceasedDate = null},
                new Actor {FirstName = "Lucy",MiddleName = "Elizabeth",LastName = "Fry",BirthDate = new DateTime(1992,3,13),City = "Wooloowin",Country = "Brisbane",Region = "Australia",DeceasedDate = null},
                new Actor {FirstName = "Rebecca",MiddleName = "Louisa Ferguson",LastName = "Sundström",BirthDate = new DateTime(1983,10,19),City = "Stockholm",Country = "Sweden",Region = "",DeceasedDate = null},
                new Actor {FirstName = "Cillian",MiddleName = "",LastName = "Murphy",BirthDate = new DateTime(1976,5,25),City = "Douglas",Country = "Cork",Region = "Ireland",DeceasedDate = null},
                new Actor {FirstName = "Claire",MiddleName = "Elizabeth",LastName = "Foy",BirthDate = new DateTime(1984,4,16),City = "Stockport",Country = "England",Region = "UK",DeceasedDate = null},
                new Actor {FirstName = "Alexandra",MiddleName = "Anna",LastName = "Daddario",BirthDate = new DateTime(1986,3,16),City = "New York City",Country = "New York",Region = "USA",DeceasedDate = null},
                new Actor {FirstName = "Gal",MiddleName = "",LastName = "Gadot",BirthDate = new DateTime(1985,4,30),City = " Rosh Ha\'ayin",Country = "Israel",Region = "",DeceasedDate = null},
                new Actor {FirstName = "Emilia",MiddleName = "",LastName = "Clarke",BirthDate = new DateTime(1986,10,23),City = "London",Country = "England",Region = "UK",DeceasedDate = null},
                new Actor {FirstName = "Bill",MiddleName = "",LastName = "Skarsgård",BirthDate = new DateTime(1990,8,9),City = "Vällingby",Country = "Sweden",Region = "",DeceasedDate = null},               

            };
            foreach (Actor a in actors)
            {
                context.Actors.Add(a);
            }

            context.SaveChanges();

            #endregion
        }
    }
}
