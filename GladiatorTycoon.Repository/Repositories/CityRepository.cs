using DataContext;
using Entities;
using Repositories.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Repositories.Repositories
{
    public class CityRepository : ICityRepository
    {
        private GladiatorTycoonDataContext _context;

        public CityRepository(GladiatorTycoonDataContext context)
        {
            _context = context;
        }

        private IQueryable<CityEntity> BaseQuery()
        {
            return _context.City;
        }

        public CityEntity Create(CityEntity cityEntity)
        {
            _context.City.Add(cityEntity);
            _context.SaveChanges();
            return cityEntity;
        }

        public bool DeleteById(int id)
        {
            var city = GetById(id);
            if (city == null) { return false; }

            _context.City.Remove(city);
            _context.SaveChanges();

            return true;
        }

        public List<CityEntity> GetAll()
        {
            return BaseQuery().ToList();
        }

        public CityEntity GetById(int id)
        {
            var city = BaseQuery()
                .FirstOrDefault(u => u.Id == id);

            return city;
        }

        public CityEntity Update(CityEntity cityEntity)
        {
            _context.City.Attach(cityEntity);
            _context.Entry(cityEntity).State = EntityState.Modified;
            _context.SaveChanges();

            return cityEntity;
        }
    }
}
