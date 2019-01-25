using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Entities
{
    public class ItemEntity
    {
        [Key]
        public int Id { get; set; }

        public int GoldCost { get; set; }
        public int MaxDurability { get; set; }
        public int CurrentDurability { get; set; }

    }
}
