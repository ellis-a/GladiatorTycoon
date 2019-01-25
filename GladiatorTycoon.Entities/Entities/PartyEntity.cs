using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GladiatorTycoon.Entities
{
    [Table("Parties")]
    public class PartyEntity
    {
        [Key]
        public int Id { get; set; }

        public List<PersonEntity> Guests { get; set; }
        public int SuccessScore { get; set; }
    }
}
