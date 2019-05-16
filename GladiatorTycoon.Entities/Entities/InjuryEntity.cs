using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GladiatorTycoon.Entities
{
    [Table("Injuries")]
    public class InjuryEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
