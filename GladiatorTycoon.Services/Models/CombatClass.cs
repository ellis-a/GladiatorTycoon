﻿using System.Collections.Generic;

namespace Services.Models
{
    public class CombatClass
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public List<Passive> Passives { get; set; }
        public List<Ability> Abilities { get; set; }
    }
}
