using GladiatorTycoon.Enums;

namespace GladiatorTycoon.Services.Models
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public Habitat Habitat { get; set; }
    }
}
