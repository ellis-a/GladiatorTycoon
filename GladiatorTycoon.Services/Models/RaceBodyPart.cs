using GladiatorTycoon.Enums;

namespace GladiatorTycoon.Services.Models
{
    public class RaceBodyPart
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string DevName { get; set; }
        public BodyPartType BodyPartType { get; set; }
        public ActionType AvailableActions { get; set; }
        public bool RequiredForLiving { get; set; }
    }
}
