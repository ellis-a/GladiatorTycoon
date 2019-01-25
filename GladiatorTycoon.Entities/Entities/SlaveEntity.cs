using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GladiatorTycoon.Entities
{
    [Table("Slaves")]
    public class SlaveEntity : PersonEntity
    {
        public int? Loyalty { get; set; }
        public MasterEntity Owner { get; set; }
    }
}
