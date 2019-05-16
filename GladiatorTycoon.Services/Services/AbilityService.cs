using GladiatorTycoon.Entities;
using GladiatorTycoon.Repositories.Interfaces;
using GladiatorTycoon.Services.Models;
using System.Collections.Generic;
using System.Linq;

namespace GladiatorTycoon.Services.Services
{
    public class AbilityService
    {
        private IAbilityRepository _abilityRepository;

        public AbilityService(IAbilityRepository abilityRepository)
        {
            _abilityRepository = abilityRepository;
        }

        public Ability EntityToRace(AbilityEntity abilityEntity)
        {
            return new Ability()
            {
                Id = abilityEntity.Id,
                Name = abilityEntity.Name,
                DamageValue = abilityEntity.DamageValue,
                Description = abilityEntity.Description,
                DoesTargetAllies = abilityEntity.DoesTargetAllies,
                DoesTargetEnemies = abilityEntity.DoesTargetEnemies,
                Effects = abilityEntity.Effects?.Select(e => ),
                HealValue = abilityEntity.HealValue,
                IsDamage = abilityEntity.IsDamage,
                IsHeal = abilityEntity.IsHeal
            };
        }

        public AbilityEntity RaceToEntity(Ability ability)
        {
            return new AbilityEntity()
            {
                Id = ability.Id,
                Name = ability.Name,
                DamageValue = ability.DamageValue,
                Description = ability.Description,
                DoesTargetAllies = ability.DoesTargetAllies,
                DoesTargetEnemies = ability.DoesTargetEnemies,
                Effects = ability.Effects?.Select(e => ),
                HealValue = ability.HealValue,
                IsDamage = ability.IsDamage,
                IsHeal = ability.IsHeal
            };
        }

        public Ability GetById(int id)
        {
            var race = _abilityRepository.GetById(id);
            return EntityToRace(race);
        }

        public List<Ability> GetAll()
        {
            var abilityEntities = _abilityRepository.GetAll();
            var abilites = abilityEntities.Select(r => EntityToRace(r)).ToList();
            return abilites;
        }

        public Ability Create(Ability ability)
        {
            var abilityEntity = _abilityRepository.Create(RaceToEntity(ability));
            return EntityToRace(abilityEntity);
        }

        public Ability Update(Ability ability)
        {
            var abilityEntity = _abilityRepository.GetById(ability.Id);

            //TODO

            _abilityRepository.Update(abilityEntity);

            return EntityToRace(abilityEntity);
        }

        public bool Delete(Ability ability)
        {
            return _abilityRepository.DeleteById(ability.Id);
        }

    }
}
