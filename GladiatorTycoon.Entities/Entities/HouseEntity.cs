using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Entities
{
    public class HouseEntity
    {
        [Key]
        public int Id { get; set; }

        public CityEntity Location { get; set; }
        public int PeopleCapacity { get; set; }
        public int Value { get; set; }
    }
}
