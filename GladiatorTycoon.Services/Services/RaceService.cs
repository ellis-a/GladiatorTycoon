﻿using Entities;
using Repositories.Interfaces;
using Services.Models;
using System.Collections.Generic;
using System.Linq;

namespace Services.Services
{
    public class RaceService
    {
        private IRaceRepository _raceRepository;
        private PassiveService _passiveService;
        private AbilityService _abilityService;
        private PersonNameService _personNameService;

        public RaceService(IRaceRepository raceRepository, IPersonNameRepository personNameRepo)
        {
            _raceRepository = raceRepository;
            _passiveService = new PassiveService();
            //_abilityService = new AbilityService();
            _personNameService = new PersonNameService(personNameRepo);
        }

        public RaceService()
        {
        }

        public Race EntityToRace(RaceEntity raceEntity)
        {
            if (raceEntity == null)
            {
                return null;
            }

            return new Race()
            {
                Id = raceEntity.Id,
                Name = raceEntity.Name,
                NegativeHabitats = raceEntity.NegativeHabitats,
                PositiveHabitats = raceEntity.PositiveHabitats,
                AvailableSexes = raceEntity.AvailableGenders,
                Passives = raceEntity.Passives?.Select(p => _passiveService.EntityToPassive(p)).ToList(),
                //Abilities = raceEntity.Abilities?.Select(a => _abilityService.EntityToAbility(a)).ToList(),
                AvailablePersonNames = raceEntity.AvailablePersonNames?.Select(n => _personNameService.EntityToPersonName(n)).ToList(),
            };
        }

        public RaceEntity RaceToEntity(Race race)
        {
            if (race == null)
            {
                return null;
            }

            return new RaceEntity()
            {
                Id = race.Id,
                Name = race.Name,
                NegativeHabitats = race.NegativeHabitats,
                PositiveHabitats = race.PositiveHabitats,
                AvailableGenders = race.AvailableSexes,
                Passives = race.Passives?.Select(p => _passiveService.PassiveToEntity(p)).ToList(),
                //Abilities = race.Abilities?.Select(a => _abilityService.AbilityToEntity(a)).ToList(),
                AvailablePersonNames = race.AvailablePersonNames?.Select(n => _personNameService.PersonNameToEntity(n)).ToList(),
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

            _raceRepository.Update(raceEntity);

            return EntityToRace(raceEntity);
        }

        public bool Delete(Race race)
        {
            return _raceRepository.DeleteById(race.Id);
        }

    }
}
