using GladiatorTycoon.Entities;
using GladiatorTycoon.Repositories.Interfaces;
using GladiatorTycoon.Services.Models;
using System.Collections.Generic;
using System.Linq;

namespace GladiatorTycoon.Services.Services
{
    public class PersonService
    {
        private IPersonRepository _personRepository;
        private RaceService _raceService;
        private CityService _cityService;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
            _raceService = new RaceService();
            _cityService = new CityService();
        }

        public Person EntityToPerson(PersonEntity personEntity)
        {
            return new Person()
            {
                Id = personEntity.Id,
                Speed = personEntity.Speed,
                Charisma = personEntity.Charisma,
                FirstName = personEntity.FirstName,
                Gold = personEntity.Gold,
                HomeCity = _cityService.EntityToCity(personEntity.HomeCity),
                Wits = personEntity.Wits,
                IsAlive = personEntity.IsAlive,
                IsMale = personEntity.IsMale,
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
                Speed = person.Speed,
                Charisma = person.Charisma,
                FirstName = person.FirstName,
                Gold = person.Gold,
                HomeCity = _cityService.CityToEntity(person.HomeCity),
                Wits = person.Wits,
                IsAlive = person.IsAlive,
                IsMale = person.IsMale,
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
            personEntity.Speed = person.Speed;
            personEntity.Charisma = person.Charisma;
            personEntity.FirstName = person.FirstName;
            personEntity.Gold = person.Gold;
            personEntity.HomeCity = _cityService.CityToEntity(person.HomeCity);
            personEntity.Wits = person.Wits;
            personEntity.IsAlive = person.IsAlive;
            personEntity.IsMale = person.IsMale;
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

    }
}
