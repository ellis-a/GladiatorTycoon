using GladiatorTycoon.DataContext;
using GladiatorTycoon.Entities;
using GladiatorTycoon.Repositories.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GladiatorTycoon.Repositories.Repositories
{
    public class BodyPartRepository : IBodyPartRepository
    {
        private GladiatorTycoonDataContext _context;

        public BodyPartRepository(GladiatorTycoonDataContext context)
        {
            _context = context;
        }

        private IQueryable<RaceBodyPartEntity> BaseQuery()
        {
            return _context.RaceBodyPart;
        }

        public RaceBodyPartEntity Create(RaceBodyPartEntity bodyPartEntity)
        {
            _context.RaceBodyPart.Add(bodyPartEntity);
            _context.SaveChanges();
            return bodyPartEntity;
        }

        public bool DeleteById(int id)
        {
            var bodyPart = GetById(id);
            if (bodyPart == null) { return false; }

            _context.RaceBodyPart.Remove(bodyPart);
            _context.SaveChanges();

            return true;
        }

        public List<RaceBodyPartEntity> GetAll()
        {
            return BaseQuery().ToList();
        }

        public RaceBodyPartEntity GetById(int id)
        {
            var bodyPart = BaseQuery()
                .FirstOrDefault(u => u.Id == id);

            return bodyPart;
        }

        public RaceBodyPartEntity Update(RaceBodyPartEntity bodyPartEntity)
        {
            _context.RaceBodyPart.Attach(bodyPartEntity);
            _context.Entry(bodyPartEntity).State = EntityState.Modified;
            _context.SaveChanges();

            return bodyPartEntity;
        }
    }
}
