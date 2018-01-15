using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDatabase.Entities
{
    public class Review :BaseEntity
    {
        public string Text { get; set; }

        public double Mark { get; set; }

        public string UsedId { get; set; }
        public User User { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
