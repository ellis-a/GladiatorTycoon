using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Models
{
    public class Gladiator : Slave
    {
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }

        public int Power { get; set; }
        public int Toughness { get; set; }

        public List<Item> Equipment { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<Armour> Armour { get; set; }
    }
}
