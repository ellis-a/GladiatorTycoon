using Enums;
using Helper;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BattleSystem
{
    public class Battle
    {
        private int _totalPhases;
        private int _lethality;

        public List<Person> Gladiators { get; }
        public Person Loser { get; private set; }
        public Person Winner { get; private set; }


        public Battle(Person gladiator1, Person gladiator2, int lethality = 0) // this should be an enum
        {
            _lethality = lethality;
            Gladiators = new List<Person>
            {
                gladiator1,
                gladiator2
            };
        }

        public void ExecuteBattle()
        {
            _totalPhases = 0;
            var combatants = Gladiators.OrderByDescending(c => c.Speed).ToList();
            var phase = 1;
            var finished = false;

            combatants.Where(c => c.Speed == 1).ToList()
                .ForEach(c => c.SpeedSum = 6);

            while (!finished)
            {
                foreach (var attacker in combatants)
                {
                    var defender = combatants.FirstOrDefault(c => c.FullName() != attacker.FullName());
                    attacker.SpeedSum += attacker.Speed;
                    if (attacker.SpeedSum < 12)
                    {
                        continue;
                    }

                    attacker.SpeedSum -= 12;

                    if (attacker.CurrentHealth < (attacker.MaxHealth / 2) - attacker.BaseBravery)
                    {
                        Loser = attacker;
                        Winner = defender;
                        finished = true;
                        break;
                    }

                    if (!DiceHelper.AttackRoll(attacker.BaseSkill, defender.BaseSkill))
                    {
                        continue;
                    }

                    var damage = (attacker.BasePower * 2) - defender.BasePower;
                    if (damage < 1)
                    {
                        damage = 1;
                    }
                    defender.CurrentHealth -= damage;

                    if (defender.CurrentHealth + defender.BaseWits < attacker.BaseWits * 2)
                    {
                        Loser = defender;
                        Winner = attacker;
                        finished = true;
                        break;
                    }
                }

                _totalPhases++;
                phase++;
                if (phase > 12)
                {
                    phase = 1;
                }
            }

            if (_lethality == 2 || (_lethality == 1 && IsLoserExecutable()) || Loser.CurrentHealth <= 0)
            {
                Loser.IsAlive = false;
            }

        }

        private bool IsLoserExecutable()
        {
            return _totalPhases > Loser.BaseCharisma + ((Winner.MaxHealth - Winner.CurrentHealth) / 4);
        }
    }
}
