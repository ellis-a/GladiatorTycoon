using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Models
{
    public class Dominus : Person
    {
        public List<Gladiator> Gladiators { get; set; }
        public List<Slave> Slaves { get; set; }
        public List<Item> Inventory { get; set; }

        public List<House> Homes { get; set; }
    }
}
