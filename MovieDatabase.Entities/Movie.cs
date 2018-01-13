using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDatabase.Entities
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Movie : BaseEntity
    {
        public string Title { get; set; }

        [Column("Trailer")]
        public string TrailerUrl { get; set; }

        [Column("Year")]
        public string YearCreated { get; set; }


        public List<MovieActor> MovieActors { get; set; }
    }
}
