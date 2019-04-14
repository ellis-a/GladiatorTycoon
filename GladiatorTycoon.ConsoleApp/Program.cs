using GladiatorTycoon.BattleSystem;
using GladiatorTycoon.Services.Models;
using System.Collections.Generic;

namespace GladiatorTycoon.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var blueteam = new List<Gladiator>();

            var battle = new Battle();
            battle.BlueTeam = blueteam;
        }
    }
}
