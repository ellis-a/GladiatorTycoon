using GladiatorTycoon.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GladiatorTycoon.Entities
{
    [Table("PersonNames")]
    public class PersonNameEntity
    {
        [Key]
        public int Id { get; set; }

        public string Text { get; set; }
        public bool IsFirstName { get; set; }
        public Gender Gender { get; set; }
    }
}
