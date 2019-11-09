using GladiatorTycoon.DataContext;
using GladiatorTycoon.Entities;
using GladiatorTycoon.Repositories.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GladiatorTycoon.Repositories.Repositories
{
    public class PersonNameRepository : IPersonNameRepository
    {
        private GladiatorTycoonDataContext _context;

        public PersonNameRepository(GladiatorTycoonDataContext context)
        {
            _context = context;
        }

        private IQueryable<PersonNameEntity> BaseQuery()
        {
            return _context.PersonName;
        }

        public PersonNameEntity Create(PersonNameEntity personNameEntity)
        {
            _context.PersonName.Add(personNameEntity);
            _context.SaveChanges();
            return personNameEntity;
        }

        public bool DeleteById(int id)
        {
            var personName = GetById(id);
            if (personName == null) { return false; }

            _context.PersonName.Remove(personName);
            _context.SaveChanges();

            return true;
        }

        public List<PersonNameEntity> GetAll()
        {
            return BaseQuery().ToList();
        }

        public PersonNameEntity GetById(int id)
        {
            var bodyPart = BaseQuery()
                .FirstOrDefault(u => u.Id == id);

            return bodyPart;
        }

        public PersonNameEntity Update(PersonNameEntity personNameEntity)
        {
            _context.PersonName.Attach(personNameEntity);
            _context.Entry(personNameEntity).State = EntityState.Modified;
            _context.SaveChanges();

            return personNameEntity;
        }
    }
}
