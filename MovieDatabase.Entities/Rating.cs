namespace MovieDatabase.Entities
{
    public class Rating : BaseEntity
    {
        public string Name { get; set; }

        public int MovieId { get; set; }

        public Movie Movie { get; set; }
    }
}
