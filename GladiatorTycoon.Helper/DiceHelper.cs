using System;
using System.Collections.Generic;
using System.Linq;

namespace GladiatorTycoon.Helper
{
    public static class DiceHelper
    {
        private static Random _dieRoll = new Random();

        public static int RollD6()
        {
            return _dieRoll.Next(1, 6);
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

        public static int RollStat()
        {
            var rolls = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                rolls.Add(RollD6());
            }
            return rolls.OrderBy(r => r).Skip(1).Take(3).Sum();
        }
    }
}
