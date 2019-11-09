using GladiatorTycoon.Entities;
using GladiatorTycoon.Enums;
using GladiatorTycoon.Helper;
using GladiatorTycoon.Repositories.Interfaces;
using GladiatorTycoon.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GladiatorTycoon.Services.Services
{
    public class PersonService
    {
        private IPersonRepository _personRepository;
        private RaceService _raceService;
        private CityService _cityService;

        public PersonService(IPersonRepository personRepo, IRaceRepository raceRepo, ICityRepository cityRepo, IPersonNameRepository personNameRepo)
        {
            _personRepository = personRepo;
            _raceService = new RaceService(raceRepo, personNameRepo);
            _cityService = new CityService(cityRepo);
        }

        public Person EntityToPerson(PersonEntity personEntity)
        {
            return new Person()
            {
                Id = personEntity.Id,
                Skill = personEntity.Skill,
                Charisma = personEntity.Charisma,
                FirstName = personEntity.FirstName,
                Gold = personEntity.Gold,
                HomeCity = _cityService.EntityToCity(personEntity.HomeCity),
                Wits = personEntity.Wits,
                IsAlive = personEntity.IsAlive,
                Gender = personEntity.Gender,
                LastName = personEntity.LastName,
                Race = _raceService.EntityToRace(personEntity.Race),
                SocialStatus = personEntity.SocialStatus,
                Power = personEntity.Power
            };
        }

        private PersonEntity PersonToEntity(Person person)
        {
            return new PersonEntity()
            {
                Id = person.Id,
                Skill = person.Skill,
                Charisma = person.Charisma,
                FirstName = person.FirstName,
                Gold = person.Gold,
                HomeCity = _cityService.CityToEntity(person.HomeCity),
                Wits = person.Wits,
                IsAlive = person.IsAlive,
                Gender = person.Gender,
                LastName = person.LastName,
                Race = _raceService.RaceToEntity(person.Race),
                SocialStatus = person.SocialStatus,
                Power = person.Power
            };
        }

        public Person GetById(int id)
        {
            var person = _personRepository.GetById(id);
            return EntityToPerson(person);
        }

        public List<Person> GetAll()
        {
            var personEntities = _personRepository.GetAll();
            var persons = personEntities.Select(r => EntityToPerson(r)).ToList();
            return persons;
        }

        public Person Create(Person person)
        {
            var personEntity = _personRepository.Create(PersonToEntity(person));
            return EntityToPerson(personEntity);
        }

        public Person Update(Person person)
        {
            var personEntity = _personRepository.GetById(person.Id);

            personEntity.Id = person.Id;
            personEntity.Skill = person.Skill;
            personEntity.Charisma = person.Charisma;
            personEntity.FirstName = person.FirstName;
            personEntity.Gold = person.Gold;
            personEntity.HomeCity = _cityService.CityToEntity(person.HomeCity);
            personEntity.Wits = person.Wits;
            personEntity.IsAlive = person.IsAlive;
            personEntity.Gender = person.Gender;
            personEntity.LastName = person.LastName;
            personEntity.Race = _raceService.RaceToEntity(person.Race);
            personEntity.SocialStatus = person.SocialStatus;
            personEntity.Power = person.Power;

            _personRepository.Update(personEntity);

            return EntityToPerson(personEntity);
        }

        public bool Delete(Person person)
        {
            return _personRepository.DeleteById(person.Id);
        }

        public Person GenerateRandomGladiator()
        {
            var result = new Person();
            var rnd = new Random();

            result.Skill = DiceHelper.RollStat();
            result.Power = DiceHelper.RollStat();
            result.Wits = DiceHelper.RollStat();
            result.Charisma = DiceHelper.RollStat();

            var allRaces = _raceService.GetAll();
            result.Race = allRaces[rnd.Next(allRaces.Count)];

            if (result.Race.AvailableSexes == Gender.Both)
            {
                result.Gender = rnd.Next(2) == 0 ? Gender.Male : Gender.Female;
            }
            else
            {
                result.Gender = result.Race.AvailableSexes;
            }

            var firstNames = result.Race.AvailablePersonNames
                .Where(n => n.IsFirstName == true && n.Gender == result.Gender)
                .Select(n => n.Text)
                .ToList();
            result.FirstName = firstNames[rnd.Next(firstNames.Count)];

            var lastNames = result.Race.AvailablePersonNames
                .Where(n => n.IsFirstName == false)
                .Select(n => n.Text)
                .ToList();
            result.LastName = lastNames[rnd.Next(lastNames.Count)];

            var cities = _cityService.GetAll(); //.Where(c => result.Race.PositiveHabitats. c.Habitat;
            result.HomeCity = cities[rnd.Next(cities.Count)];

            result.IsAlive = true;
            result.Gold = 0;
            result.SocialStatus = SocialStatus.Slave;

            return result;
        }
    }
}
