using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GladiatorTycoon.Entities
{
    [Table("Classes")]
    public class ClassEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public List<PassiveEntity> Passives { get; set; }
    }
}
