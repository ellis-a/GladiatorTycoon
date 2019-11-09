using GladiatorTycoon.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using GladiatorTycoon.Entities;
using GladiatorTycoon.DataContext;
using System.Data.Entity;

namespace GladiatorTycoon.Repositories.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private GladiatorTycoonDataContext _context;

        public PersonRepository(GladiatorTycoonDataContext context)
        {
            _context = context;
        }

        private IQueryable<PersonEntity> BaseQuery()
        {
            return _context.Person
                .Include(p => p.HomeCity)
                .Include(p => p.Race);
        }

        public PersonEntity Create(PersonEntity personEntity)
        {
            var cityId = personEntity.HomeCity.Id;
            personEntity.HomeCity = _context.City.FirstOrDefault(c => c.Id == cityId);
            var raceId = personEntity.Race.Id;
            personEntity.Race = _context.Race.FirstOrDefault(r => r.Id == raceId);
            _context.Person.Add(personEntity);
            _context.SaveChanges();
            return personEntity;
        }

        public bool DeleteById(int id)
        {
            var person = GetById(id);
            if (person == null) { return false; }

            _context.Person.Remove(person);
            _context.SaveChanges();

            return true;
        }

        public List<PersonEntity> GetAll()
        {
            return BaseQuery().ToList();
        }

        public PersonEntity GetById(int id)
        {
            var person = BaseQuery()
                .FirstOrDefault(u => u.Id == id);

            return person;
        }

        public PersonEntity Update(PersonEntity personEntity)
        {
            _context.Person.Attach(personEntity);
            _context.Entry(personEntity).State = EntityState.Modified;
            _context.SaveChanges();

            return personEntity;
        }
    }
}
