using GladiatorTycoon.Enums;
using System.Collections.Generic;
using System.Text;

namespace GladiatorTycoon.Services.Models
{
    public class Race
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public List<Passive> Passives { get; set; }
        public List<Ability> Abilities { get; set; }

        public string PositiveHabitats { get; set; }
        public string NegativeHabitats { get; set; }

        public List<RaceBodyPart> BodyParts { get; set; }

        public string ConvertEnumListToString(List<Habitat> habitats)
        {
            var result = new StringBuilder();
            foreach (var habitat in habitats)
            {
                result.Append($"{habitat.ToString()},");
            }
            return result.ToString().Trim(',');
        }
    }
}
