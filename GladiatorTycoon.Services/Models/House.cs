namespace Services.Models
{
    public class House
    {
        public int Id { get; set; }

        public City Location { get; set; }
        public int PeopleCapacity { get; set; }
        public int Value { get; set; }
    }
}
