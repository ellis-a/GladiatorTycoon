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

        private IQueryable<BodyPartEntity> BaseQuery()
        {
            return _context.BodyPart;
        }

        public BodyPartEntity Create(BodyPartEntity bodyPartEntity)
        {
            _context.BodyPart.Add(bodyPartEntity);
            _context.SaveChanges();
            return bodyPartEntity;
        }

        public bool DeleteById(int id)
        {
            var bodyPart = GetById(id);
            if (bodyPart == null) { return false; }

            _context.BodyPart.Remove(bodyPart);
            _context.SaveChanges();

            return true;
        }

        public List<BodyPartEntity> GetAll()
        {
            return BaseQuery().ToList();
        }

        public BodyPartEntity GetById(int id)
        {
            var bodyPart = BaseQuery()
                .FirstOrDefault(u => u.Id == id);

            return bodyPart;
        }

        public BodyPartEntity Update(BodyPartEntity bodyPartEntity)
        {
            _context.BodyPart.Attach(bodyPartEntity);
            _context.Entry(bodyPartEntity).State = EntityState.Modified;
            _context.SaveChanges();

            return bodyPartEntity;
        }
    }
}
