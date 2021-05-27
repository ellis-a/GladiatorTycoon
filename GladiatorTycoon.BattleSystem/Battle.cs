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
            while (!finished)
            {
                foreach (var attacker in combatants)
                {
                    var defender = combatants.FirstOrDefault(c => c.FullName() != attacker.FullName());
                    if (!IsValidPhase(phase, attacker.Speed))
                    {
                        continue;
                    }

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

                    if (defender.CurrentHealth + defender.BaseWits > attacker.BaseWits * 2)
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
            
            if (_lethality == 2 || (_lethality == 1 && IsLoserExecutable()))
            {
                Loser.IsAlive = false;
            }

        }

        // this is shit
        private bool IsLoserExecutable()
        {
            if (Loser.CurrentHealth <= 0)
            {
                Loser.IsAlive = false;
                return false;
            }

            if (_totalPhases < Loser.BaseCharisma + (Winner.MaxHealth - Winner.CurrentHealth))
            {
                return true;
            }

            return false;
        }

        private bool IsValidPhase(int phase, int speed)
        {
            if (speed < 1)
            {
                speed = 1;
            }
            else if (speed > 12)
            {
                speed = 12;
            }

            switch (speed)
            {
                case 1:
                    return phase == 7;
                case 2:
                    return phase == 6 || phase == 12;
                case 3:
                    return phase == 4 || phase == 8 || phase == 12;
                case 4:
                    return phase == 3 || phase == 6 || phase == 9 || phase == 12;
                case 5:
                    return phase == 3 || phase == 5 || phase == 8 || phase == 10 || phase == 12;
                case 6:
                    return phase == 2 || phase == 4 || phase == 6 || phase == 8 || phase == 10 || phase == 12;
                case 7:
                    return phase != 1 && phase != 3 && phase != 5 && phase != 8 && phase != 10;
                case 8:
                    return phase != 1 && phase != 4 && phase != 7 && phase != 10;
                case 9:
                    return phase != 1 && phase != 5 && phase != 9;
                case 10:
                    return phase != 1 && phase != 7;
                case 11:
                    return phase != 1;
                case 12:
                default:
                    return true;
            }
        }
    }
}
