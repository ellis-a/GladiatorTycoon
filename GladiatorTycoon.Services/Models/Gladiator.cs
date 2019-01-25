using System.Collections.Generic;

namespace GladiatorTycoon.Services.Models
{
    public class Gladiator : Slave
    {
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }

        public int Offense { get; set; }
        public int Defense { get; set; }

        //public List<Item> Equipment { get; set; }
        //public List<Weapon> Weapons { get; set; }
        //public List<Armour> Armour { get; set; }
    }
}
