using GladiatorTycoon.BattleSystem;
using GladiatorTycoon.Services.Models;
using System.Collections.Generic;

namespace GladiatorTycoon.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var blueTeam = new List<Gladiator>();
            var redTeam = new List<Gladiator>();

            var battle = new Battle();
            battle.BlueTeam = blueTeam;
            battle.RedTeam = redTeam;

            battle.ExecuteBattle();
        }
    }
}
