using GladiatorTycoon.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Models
{
    public class Armour : Item
    {
        public int Toughness { get; set; }
        public ArmourSlot ArmourSlot { get; set; }
    }
}
