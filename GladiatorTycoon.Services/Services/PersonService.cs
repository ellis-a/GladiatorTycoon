using Entities;
using Enums;
using Helper;
using Repositories.Interfaces;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Services
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
                BaseSkill = personEntity.BaseSkill,
                BaseCharisma = personEntity.BaseCharisma,
                FirstName = personEntity.FirstName,
                Gold = personEntity.Gold,
                HomeCity = _cityService.EntityToCity(personEntity.HomeCity),
                BaseWits = personEntity.BaseWits,
                IsAlive = personEntity.IsAlive,
                Gender = personEntity.Gender,
                LastName = personEntity.LastName,
                Race = _raceService.EntityToRace(personEntity.Race),
                SocialStatus = personEntity.SocialStatus,
                BasePower = personEntity.BasePower,
                BaseBravery = personEntity.BaseBravery,
                Speed = personEntity.Speed,
                CurrentHealth = personEntity.CurrentHealth,
                MaxHealth = personEntity.MaxHealth,
                Popularity = personEntity.Popularity
            };
        }

        private PersonEntity PersonToEntity(Person person)
        {
            return new PersonEntity()
            {
                Id = person.Id,
                BaseSkill = person.BaseSkill,
                BaseCharisma = person.BaseCharisma,
                FirstName = person.FirstName,
                Gold = person.Gold,
                HomeCity = _cityService.CityToEntity(person.HomeCity),
                BaseWits = person.BaseWits,
                IsAlive = person.IsAlive,
                Gender = person.Gender,
                LastName = person.LastName,
                Race = _raceService.RaceToEntity(person.Race),
                SocialStatus = person.SocialStatus,
                BasePower = person.BasePower,
                BaseBravery = person.BaseBravery,
                Speed = person.Speed,
                CurrentHealth = person.CurrentHealth,
                MaxHealth = person.MaxHealth,
                Popularity = person.Popularity
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
            personEntity.BaseSkill = person.BaseSkill;
            personEntity.BaseCharisma = person.BaseCharisma;
            personEntity.FirstName = person.FirstName;
            personEntity.Gold = person.Gold;
            personEntity.HomeCity = _cityService.CityToEntity(person.HomeCity);
            personEntity.BaseWits = person.BaseWits;
            personEntity.IsAlive = person.IsAlive;
            personEntity.Gender = person.Gender;
            personEntity.LastName = person.LastName;
            personEntity.Race = _raceService.RaceToEntity(person.Race);
            personEntity.SocialStatus = person.SocialStatus;
            personEntity.BasePower = person.BasePower;
            personEntity.BaseBravery = person.BaseBravery;
            personEntity.Speed = person.Speed;
            personEntity.CurrentHealth = person.CurrentHealth;
            personEntity.MaxHealth = person.MaxHealth;
            personEntity.Popularity = person.Popularity;

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

            result.BaseSkill = DiceHelper.RollStat();
            result.BasePower = DiceHelper.RollStat();
            result.BaseWits = DiceHelper.RollStat();
            result.BaseCharisma = DiceHelper.RollStat();
            result.BaseBravery = DiceHelper.RollStat(); 
            result.Speed = DiceHelper.RollSpeed();
            result.MaxHealth = DiceHelper.RollHealth();

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
