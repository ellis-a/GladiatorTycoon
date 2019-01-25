using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Entities
{
    public class PartyEntity
    {
        [Key]
        public int Id { get; set; }

        public List<PersonEntity> Guests { get; set; }
        public int SuccessScore { get; set; }
    }
}
