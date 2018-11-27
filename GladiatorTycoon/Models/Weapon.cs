using GladiatorTycoon.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Models
{
    public class Weapon : Item
    {
        public int Power { get; set; }
        public WeaponType WeaponType { get; set; }
        public bool IsTwoHander { get; set; }
    }
}
