using GladiatorTycoon.Enums;
using System.Collections.Generic;

namespace GladiatorTycoon.Services.Models
{
    public class Ability
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public List<Passive> Effects { get; set; }
        public ActionType ActionType { get; set; }
        public ReactionTrigger ReactionTrigger { get; set; }
        public MagicType MagicTypes { get; set; }
        public int Duration { get; set; }
        public int PowerMod { get; set; }
        public int SkillMod { get; set; }
    }
}
