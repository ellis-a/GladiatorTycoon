using GladiatorTycoon.Entities;
using GladiatorTycoon.Repositories.Interfaces;
using GladiatorTycoon.Services.Models;
using System.Collections.Generic;
using System.Linq;

namespace GladiatorTycoon.Services.Services
{
    public class RaceService
    {
        private IRaceRepository _raceRepository;
        private PassiveService _passiveService;
        private RaceBodyPartService _raceBodyPartService;

        public RaceService(IRaceRepository raceRepository)
        {
            _raceRepository = raceRepository;
            _passiveService = new PassiveService();
        }

        public RaceService()
        {
        }

        public Race EntityToRace(RaceEntity raceEntity)
        {
            return new Race()
            {
                Id = raceEntity.Id,
                Name = raceEntity.Name,
                NegativeHabitats = raceEntity.NegativeHabitats,
                PositiveHabitats = raceEntity.PositiveHabitats,
                Passives = raceEntity.Passives?.Select(p => _passiveService.EntityToPassive(p)).ToList(),
                Abilities = raceEntity.Abilities?.Select(a => _abilityService.EntityToAbility(a)).ToList(),
                BodyParts = raceEntity.BodyParts?.Select(b => _raceBodyPartService.EntityToBodyPart(b)).ToList()
            };
        }

        public RaceEntity RaceToEntity(Race race)
        {
            return new RaceEntity()
            {
                Id = race.Id,
                Name = race.Name,
                NegativeHabitats = race.NegativeHabitats,
                PositiveHabitats = race.PositiveHabitats,
                Passives = race.Passives?.Select(p => _passiveService.PassiveToEntity(p)).ToList(),
                Abilities = race.Abilities?.Select(a => _abilityService.PassiveToEntity(a)).ToList(),
                BodyParts = race.BodyParts?.Select(b => _raceBodyPartService.BodyPartToEntity(b)).ToList()
            };
        }

        public Race GetById(int id)
        {
            var race = _raceRepository.GetById(id);
            return EntityToRace(race);
        }

        public List<Race> GetAll()
        {
            var raceEntities = _raceRepository.GetAll();
            var races = raceEntities.Select(r => EntityToRace(r)).ToList();
            return races;
        }

        public Race Create(Race race)
        {
            var raceEntity = _raceRepository.Create(RaceToEntity(race));
            return EntityToRace(raceEntity);
        }

        public Race Update(Race race)
        {
            var raceEntity = _raceRepository.GetById(race.Id);

            raceEntity.Id = race.Id;
            raceEntity.Name = race.Name;
            raceEntity.NegativeHabitats = race.NegativeHabitats;
            raceEntity.PositiveHabitats = race.PositiveHabitats;
            raceEntity.Passives = race.Passives.Select(p => _passiveService.PassiveToEntity(p)).ToList();
            raceEntity.Abilities = race.Abilities.Select(a => _abilityService.AbilityToEntity(a)).ToList();
            raceEntity.BodyParts = race.BodyParts.Select(b => _raceBodyPartService.BodyPartToEntity(b)).ToList();

            _raceRepository.Update(raceEntity);

            return EntityToRace(raceEntity);
        }

        public bool Delete(Race race)
        {
            return _raceRepository.DeleteById(race.Id);
        }

    }
}
