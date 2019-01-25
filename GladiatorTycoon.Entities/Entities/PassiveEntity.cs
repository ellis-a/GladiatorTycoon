using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GladiatorTycoon.Entities
{
    [Table("Passives")]
    public class PassiveEntity
    {
        [Key]
        public int Id { get; set; }

    }
}
