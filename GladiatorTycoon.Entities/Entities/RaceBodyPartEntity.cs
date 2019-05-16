using GladiatorTycoon.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GladiatorTycoon.Entities
{
    [Table("RaceBodyParts")]
    public class RaceBodyPartEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string DevName { get; set; }
        public BodyPartType BodyPartType { get; set; }
        public ActionType AvailableActions { get; set; }
        public bool RequiredForLiving { get; set; }
    }
}
