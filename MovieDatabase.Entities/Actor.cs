using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieDatabase.Entities
{
    public class Actor : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public DateTime? DeceasedDate { get; set; }

        [Required]
        public string Country { get; set; }

        public string State { get; set; }

        [Required]
        public string City { get; set; }

        public string FullName => $"{FirstName} {MiddleName} {LastName}";

        public string FullBirthPlace => string.IsNullOrEmpty(this.State) ? $"{City}, {Country}" : $"{City}, {State}, {Country}";

        public int Age => DateTime.Now.Year - BirthDate.Date.Year;

        public List<MovieActor> MovieActors { get; set; }

    }
}
