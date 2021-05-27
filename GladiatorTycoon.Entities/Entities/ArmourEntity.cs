using Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Armours")]
    public class ArmourEntity : ItemEntity
    {
        public int Defense { get; set; }
        public ArmourSlot ArmourSlot { get; set; }
    }
}
