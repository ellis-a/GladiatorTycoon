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
                Racials = raceEntity.Racials?.Select(r => _passiveService.EntityToPassive(r)).ToList()
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
                Racials = race.Racials?.Select(r => _passiveService.PassiveToEntity(r)).ToList()
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
            raceEntity.Racials = race.Racials.Select(r => _passiveService.PassiveToEntity(r)).ToList();

            _raceRepository.Update(raceEntity);

            return EntityToRace(raceEntity);
        }

        public bool Delete(Race race)
        {
            return _raceRepository.DeleteById(race.Id);
        }

    }
}
