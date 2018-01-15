namespace MovieDatabase.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;


    public class Movie : BaseEntity
    {
        public string Title { get; set; }

        [Column("Trailer")]
        public string TrailerUrl { get; set; }

        [Column("Cover")]
        public string CoverUrl { get; set; }

        public int Length { get; set; }

        public string Description { get; set; }

        public int Budget { get; set; }

        public DateTime ReleaseDate { get; set; }

        public Rating Rating { get; set; }

        public List<Genre> Genre { get; set; }
    
        public List<MovieActor> MovieActors { get; set; }

        public List<Review> Reviews { get; set; }

    }
}
