using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GladiatorTycoon.Enums;
using System.Text;

namespace GladiatorTycoon.Models
{
    public class Race
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public List<PassiveTrait> Racials { get; set; }

        public string PositiveHabitats { get; set; }
        public string NegativeHabitats { get; set; }

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
