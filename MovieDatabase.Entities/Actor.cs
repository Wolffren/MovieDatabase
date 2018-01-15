namespace MovieDatabase.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Actor : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Biography { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public DateTime? DeceasedDate { get; set; }

        [Required]
        public string Region { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string City { get; set; }


        public string FullName => $"{FirstName} {LastName}";

        public string FullBirthPlace => string.IsNullOrEmpty(this.Region) ? $"{City}, {Country}" : $"{City}, {Country}, {Region}";

        public int Age => DateTime.Now.Year - BirthDate.Date.Year;

        public List<MovieActor> MovieActors { get; set; }

    }
}
