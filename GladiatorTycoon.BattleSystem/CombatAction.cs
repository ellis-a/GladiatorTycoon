using GladiatorTycoon.Services.Models;

namespace GladiatorTycoon.BattleSystem
{
    public class CombatAction
    {
        public static void TakeAction(Gladiator self, Tactic tactic)
        {
            var ability = tactic.Ability;

            //if (ability.Bounce != null)
            //{
            //    TakeAction(null, null);
            //}

        }
    }
}
