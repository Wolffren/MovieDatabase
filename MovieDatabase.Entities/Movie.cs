namespace MovieDatabase.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public class Movie : BaseEntity
    {
        public string Title { get; set; }

        [Column("Trailer")]
        public string TrailerUrl { get; set; }

        [Column("Cover")]
        public string CoverUrl { get; set; }

        [Required]
        public int Length { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        
        public int Budget { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public Rating Rating { get; set; }

        public int RatingId { get; set; }

        public Genre Genre { get; set; }

        public int GenreId { get; set; }

        public List<MovieActor> MovieActors { get; set; }

        public List<Review> Reviews { get; set; }

    }
}
