using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Passives")]
    public class PassiveEntity
    {
        [Key]
        public int Id { get; set; }

    }
}
