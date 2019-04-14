using GladiatorTycoon.Enums;
using GladiatorTycoon.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GladiatorTycoon.BattleSystem
{
    public class Battle
    {
        public List<Gladiator> RedTeam { get; set; }
        public List<Gladiator> BlueTeam { get; set; }
        //public List<Gladiator> GreenTeam { get; set; }
        //public List<Gladiator> YellowTeam { get; set }

        public void ExecuteBattle()
        {
            var gladiators = new List<Gladiator>();
            gladiators.AddRange(RedTeam);
            gladiators.AddRange(BlueTeam);

            gladiators = gladiators.OrderByDescending(g => g.Speed).ToList();

            foreach (var gladiator in gladiators)
            {
                GladiatorTurn(gladiator);
            }
        }

        public void GladiatorTurn(Gladiator gladiator)
        {
            foreach (var tactic in gladiator.Tactics)
            {
                if (CheckCondition(gladiator, tactic))
                {
                    CombatAction.TakeAction(gladiator, tactic);
                    break;
                }
            }
        }

        public bool CheckCondition(Gladiator self, Tactic tactic)
        {
            var result = false;
            Gladiator target = null;
            List<Gladiator> targets = null;
            bool multiTargets = false;
            var conditionTarget = tactic.ConditionTarget;
            var conditionType = tactic.ConditionType;
            var conditionValue = tactic.ConditionValue;

            if (conditionTarget == CombatTarget.AllAllies || conditionTarget == CombatTarget.AllEnemies ||
                conditionTarget == CombatTarget.AnyAlly || conditionTarget == CombatTarget.AnyEnemy)
            {
                multiTargets = true;
                targets = GetMultiTargets(self, conditionTarget);
            }
            else
            {
                target = GetTarget(self, conditionTarget);
            }

            if (!multiTargets)
            {
                result = CheckConditionOnTarget(target, conditionType, conditionValue);
            }
            else
            {
                var isAll = conditionTarget == CombatTarget.AllAllies || conditionTarget == CombatTarget.AllEnemies;
                result = CheckConditionOnTargets(targets, conditionType, conditionValue, isAll);
            }

            return result;
        }

        private static bool CheckConditionOnTarget(Gladiator target, TacticConditionType conditionType, int conditionValue)
        {
            var result = false;

            if (target.GetCombatFlags().HasFlag(CombatFlags.Threatening))
            {
                return true;
            }

            switch (conditionType)
            {
                case TacticConditionType.HealthBelowPercent:
                    if (GetHealthPercentage(target) < conditionValue)
                    {
                        result = true;
                    }
                    break;
                case TacticConditionType.HealthEqualOrAbovePercent:
                    if (GetHealthPercentage(target) >= conditionValue)
                    {
                        result = true;
                    }
                    break;
                case TacticConditionType.AlwaysTrue:
                    result = true;
                    break;
            }

            return result;
        }

        private static bool CheckConditionOnTargets(List<Gladiator> targets, TacticConditionType conditionType, int conditionValue, bool isAll)
        {
            var result = false;

            switch (conditionType)
            {
                case TacticConditionType.HealthBelowPercent:
                    if ((isAll && targets.All(t => GetHealthPercentage(t) < conditionValue)) ||
                        (!isAll && targets.Any(t => GetHealthPercentage(t) < conditionValue)))
                    {
                        result = true;
                    }
                    break;
                case TacticConditionType.HealthEqualOrAbovePercent:
                    if ((isAll && targets.All(t => GetHealthPercentage(t) >= conditionValue)) ||
                        (!isAll && targets.Any(t => GetHealthPercentage(t) >= conditionValue)))
                    {
                        result = true;
                    }
                    break;
                case TacticConditionType.AlwaysTrue:
                    result = true;
                    break;
            }

            return result;
        }

        private static int GetHealthPercentage(Gladiator t)
        {
            return t.CurrentHealth / t.MaxHealth;
        }

        private List<Gladiator> GetMultiTargets(Gladiator self, CombatTarget conditionTarget)
        {
            switch (conditionTarget)
            {
                case CombatTarget.AnyAlly:
                case CombatTarget.AllAllies:
                    if (RedTeam.Contains(self))
                    {
                        return RedTeam;
                    }
                    return BlueTeam;
                case CombatTarget.AnyEnemy:
                case CombatTarget.AllEnemies:
                    if (BlueTeam.Contains(self))
                    {
                        return RedTeam;
                    }
                    return BlueTeam;
                default:
                    throw new Exception("No target selected.");
            }
        }

        private Gladiator GetTarget(Gladiator self, CombatTarget conditionTarget)
        {
            var rnd = new Random();
            int r;
            switch (conditionTarget)
            {
                case CombatTarget.Self:
                    return self;
                case CombatTarget.NearestAlly:
                    throw new NotImplementedException();
                    //return self.GetNearestAlly();
                case CombatTarget.NearestEnemy:
                    throw new NotImplementedException();
                    //return self.GetNearestEnemy();
                case CombatTarget.LowestHealthAlly:
                    if (RedTeam.Contains(self))
                    {
                        return RedTeam.OrderBy(g => g.CurrentHealth).FirstOrDefault();
                    }
                    return BlueTeam.OrderBy(g => g.CurrentHealth).FirstOrDefault();
                case CombatTarget.LowestHealthEnemy:
                    if (BlueTeam.Contains(self))
                    {
                        return RedTeam.OrderBy(g => g.CurrentHealth).FirstOrDefault();
                    }
                    return BlueTeam.OrderBy(g => g.CurrentHealth).FirstOrDefault();
                case CombatTarget.HighestHealthAlly:
                    if (RedTeam.Contains(self))
                    {
                        return RedTeam.OrderByDescending(g => g.CurrentHealth).FirstOrDefault();
                    }
                    return BlueTeam.OrderByDescending(g => g.CurrentHealth).FirstOrDefault();
                case CombatTarget.HighestHealthEnemy:
                    if (BlueTeam.Contains(self))
                    {
                        return RedTeam.OrderByDescending(g => g.CurrentHealth).FirstOrDefault();
                    }
                    return BlueTeam.OrderByDescending(g => g.CurrentHealth).FirstOrDefault();
                case CombatTarget.RandomAlly:
                    if (RedTeam.Contains(self))
                    {
                        r = rnd.Next(RedTeam.Count);
                        return RedTeam[r];
                    }
                    r = rnd.Next(BlueTeam.Count);
                    return BlueTeam[r];
                case CombatTarget.RandomEnemy:
                    if (BlueTeam.Contains(self))
                    {
                        r = rnd.Next(RedTeam.Count);
                        return RedTeam[r];
                    }
                    r = rnd.Next(BlueTeam.Count);
                    return BlueTeam[r];
                default:
                    throw new Exception("No target selected.");
            }
        }
    }
}
