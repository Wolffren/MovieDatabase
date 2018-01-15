using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDatabase.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Genre :BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int MovieId { get; set; }

        public Movie Movie { get; set; }
    }
}
