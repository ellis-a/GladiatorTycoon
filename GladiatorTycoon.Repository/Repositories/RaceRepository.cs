using GladiatorTycoon.DataContext;
using GladiatorTycoon.Entities;
using GladiatorTycoon.Repositories.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GladiatorTycoon.Repositories.Repositories
{
    public class RaceRepository : IRaceRepository
    {
        private GladiatorTycoonDataContext _context;

        public RaceRepository(GladiatorTycoonDataContext context)
        {
            _context = context;
        }

        private IQueryable<RaceEntity> BaseQuery()
        {
            return _context.Race;
        }

        public RaceEntity Create(RaceEntity raceEntity)
        {
            _context.Race.Add(raceEntity);
            _context.SaveChanges();
            return raceEntity;
        }

        public bool DeleteById(int id)
        {
            var race = GetById(id);
            if (race == null) { return false; }

            _context.Race.Remove(race);
            _context.SaveChanges();

            return true;
        }

        public List<RaceEntity> GetAll()
        {
            return BaseQuery().ToList();
        }

        public RaceEntity GetById(int id)
        {
            var race = BaseQuery()
                .FirstOrDefault(u => u.Id == id);

            return race;
        }

        public RaceEntity Update(RaceEntity raceEntity)
        {
            _context.Race.Attach(raceEntity);
            _context.Entry(raceEntity).State = EntityState.Modified;
            _context.SaveChanges();

            return raceEntity;
        }
    }
}
