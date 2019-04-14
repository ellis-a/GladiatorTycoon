using GladiatorTycoon.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorTycoon.Services.Models
{
    public class Tactic
    {
        public CombatTarget ConditionTarget { get; set; }
        public TacticConditionType ConditionType { get; set; }
        public int ConditionValue { get; set; }
        public Ability Ability { get; set; }
        public CombatTarget AbilityTarget { get; set; }

    }
}
