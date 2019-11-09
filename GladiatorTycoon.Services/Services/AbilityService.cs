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
        private PassiveService _passiveService;

        public AbilityService(IAbilityRepository abilityRepository, IPassiveRepository passiveRepository)
        {
            _abilityRepository = abilityRepository;
            _passiveService = new PassiveService(passiveRepository);
        }

        public Ability EntityToAbility(AbilityEntity abilityEntity)
        {
            return new Ability()
            {
                Id = abilityEntity.Id,
                Name = abilityEntity.Name,
                Description = abilityEntity.Description,
                Effects = abilityEntity.Effects?.Select(e => _passiveService.EntityToPassive(e)).ToList(),
                //TODO
            };
        }

        public AbilityEntity AbilityToEntity(Ability ability)
        {
            return new AbilityEntity()
            {
                Id = ability.Id,
                Name = ability.Name,
                Description = ability.Description,
                Effects = ability.Effects?.Select(e => _passiveService.PassiveToEntity(e)).ToList(),
                //TODO
            };
        }

        public Ability GetById(int id)
        {
            var race = _abilityRepository.GetById(id);
            return EntityToAbility(race);
        }

        public List<Ability> GetAll()
        {
            var abilityEntities = _abilityRepository.GetAll();
            var abilites = abilityEntities.Select(r => EntityToAbility(r)).ToList();
            return abilites;
        }

        public Ability Create(Ability ability)
        {
            var abilityEntity = _abilityRepository.Create(AbilityToEntity(ability));
            return EntityToAbility(abilityEntity);
        }

        public Ability Update(Ability ability)
        {
            var abilityEntity = _abilityRepository.GetById(ability.Id);

            abilityEntity.Description = ability.Description;
            abilityEntity.Effects = ability.Effects.Select(e => _passiveService.PassiveToEntity(e)).ToList();
            abilityEntity.Id = ability.Id;
            abilityEntity.Name = ability.Name;
            //TODO

            _abilityRepository.Update(abilityEntity);

            return EntityToAbility(abilityEntity);
        }

        public bool Delete(Ability ability)
        {
            return _abilityRepository.DeleteById(ability.Id);
        }

    }
}
