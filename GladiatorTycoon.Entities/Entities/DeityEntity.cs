using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Entities
{
    public class DeityEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
