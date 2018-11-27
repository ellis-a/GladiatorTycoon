using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Models
{
    public class Merchant : Person
    {
        public List<Item> Wares { get; set; }
    }
}
