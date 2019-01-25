using GladiatorTycoon.DataContext;
using GladiatorTycoon.Entities;
using GladiatorTycoon.Repositories.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GladiatorTycoon.Repositories.Repositories
{
    public class PassiveRepository : IPassiveRepository
    {
        private GladiatorTycoonDataContext _context;

        public PassiveRepository(GladiatorTycoonDataContext context)
        {
            _context = context;
        }

        private IQueryable<PassiveEntity> BaseQuery()
        {
            return _context.Passive;
        }

        public PassiveEntity Create(PassiveEntity passiveEntity)
        {
            _context.Passive.Add(passiveEntity);
            _context.SaveChanges();
            return passiveEntity;
        }

        public bool DeleteById(int id)
        {
            var passive = GetById(id);
            if (passive == null) { return false; }

            _context.Passive.Remove(passive);
            _context.SaveChanges();

            return true;
        }

        public List<PassiveEntity> GetAll()
        {
            return BaseQuery().ToList();
        }

        public PassiveEntity GetById(int id)
        {
            var passive = BaseQuery()
                .FirstOrDefault(u => u.Id == id);

            return passive;
        }

        public PassiveEntity Update(PassiveEntity passiveEntity)
        {
            _context.Passive.Attach(passiveEntity);
            _context.Entry(passiveEntity).State = EntityState.Modified;
            _context.SaveChanges();

            return passiveEntity;
        }
    }
}
