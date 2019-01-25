using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Entities
{
    public class ArenaEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public CityEntity City { get; set; }
    }
}
