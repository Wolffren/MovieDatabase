using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDatabase.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Review :BaseEntity
    {
        [Required]
        public string Text { get; set; }

        [Required]
        public double Mark { get; set; }

        public string UsedId { get; set; }
        public User User { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
