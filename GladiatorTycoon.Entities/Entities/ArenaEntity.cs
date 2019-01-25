using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GladiatorTycoon.Entities
{
    [Table("Arenas")]
    public class ArenaEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public CityEntity City { get; set; }
    }
}
