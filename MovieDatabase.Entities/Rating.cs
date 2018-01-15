namespace MovieDatabase.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Rating : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
