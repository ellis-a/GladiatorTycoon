using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Items")]
    public class ItemEntity
    {
        [Key]
        public int Id { get; set; }

        public int GoldCost { get; set; }
        public int MaxDurability { get; set; }
        public int CurrentDurability { get; set; }

    }
}
