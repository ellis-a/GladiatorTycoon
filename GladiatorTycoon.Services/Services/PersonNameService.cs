using GladiatorTycoon.Entities;
using GladiatorTycoon.Repositories.Interfaces;
using GladiatorTycoon.Services.Models;
using System.Collections.Generic;
using System.Linq;

namespace GladiatorTycoon.Services.Services
{
    public class PersonNameService
    {
        private IPersonNameRepository _personNameRepository;

        public PersonNameService(IPersonNameRepository personNameRepository)
        {
            _personNameRepository = personNameRepository;
        }

        public PersonNameService()
        {
        }

        public PersonName EntityToPersonName(PersonNameEntity personNameEntity)
        {
            return new PersonName()
            {
                Id = personNameEntity.Id,
                Gender = personNameEntity.Gender,
                IsFirstName = personNameEntity.IsFirstName,
                Text = personNameEntity.Text
            };
        }

        public PersonNameEntity PersonNameToEntity(PersonName personName)
        {
            return new PersonNameEntity()
            {
                Id = personName.Id,
                Gender = personName.Gender,
                IsFirstName = personName.IsFirstName,
                Text = personName.Text
            };
        }

        public PersonName GetById(int id)
        {
            var bodyPart = _personNameRepository.GetById(id);
            return EntityToPersonName(bodyPart);
        }

        public List<PersonName> GetAll()
        {
            var bodyPartEntities = _personNameRepository.GetAll();
            var bodyParts = bodyPartEntities.Select(r => EntityToPersonName(r)).ToList();
            return bodyParts;
        }

        public PersonName Create(PersonName bodyPart)
        {
            var bodyPartEntity = _personNameRepository.Create(PersonNameToEntity(bodyPart));
            return EntityToPersonName(bodyPartEntity);
        }

        public PersonName Update(PersonName personName)
        {
            var personNameEntity = _personNameRepository.GetById(personName.Id);

            personNameEntity.Id = personName.Id;
            personNameEntity.Gender = personName.Gender;
            personNameEntity.IsFirstName = personName.IsFirstName;
            personNameEntity.Text = personName.Text;

            _personNameRepository.Update(personNameEntity);

            return EntityToPersonName(personNameEntity);
        }

        public bool Delete(PersonName bodyPart)
        {
            return _personNameRepository.DeleteById(bodyPart.Id);
        }
    }
}
