using System;
using System.Collections.Generic;
using System.Linq;

namespace Helper
{
    public static class DiceHelper
    {
        private static Random _dieRoll = new Random();

        public static int RollD6()
        {
            return _dieRoll.Next(1, 6);
        }
        
        public static int RollD10()
        {
            return _dieRoll.Next(1, 10);
        }
        
        public static int RollXD6Dice(int numberOfDice)
        {
            var result = 0;
            for (int i = 0; i < numberOfDice; i++)
            {
                result += RollD6();
            }
            return result;
        }

        public static bool AttackRoll(int attackerSkill, int defenderSkill)
        {
            var chanceToHit = 7 + attackerSkill - defenderSkill;
            var roll = _dieRoll.Next(1, 20);
            return roll < chanceToHit || roll == 1;
        }

        public static int RollStat()
        {
            var rolls = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                rolls.Add(RollD6());
            }
            return rolls.OrderBy(r => r).Skip(1).Take(3).Sum();
        }

        public static int RollSpeed()
        {
            return (RollD6() / 2) + 3;
        }

        public static int RollHealth()
        {
            return RollD10() + RollD10() + 30;
        }
    }
}
