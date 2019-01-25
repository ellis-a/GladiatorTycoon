using GladiatorTycoon.Enums;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Entities
{
    public class CityEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public Habitat Habitat { get; set; }
    }
}
