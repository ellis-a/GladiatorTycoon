using System;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        public int GoldCost { get; set; }
        public int MaxDurability { get; set; }
        public int CurrentDurability { get; set; }

    }
}
