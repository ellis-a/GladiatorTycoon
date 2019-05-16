using GladiatorTycoon.DataContext;
using GladiatorTycoon.Entities;
using GladiatorTycoon.Repositories.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GladiatorTycoon.Repositories.Repositories
{
    public class AbilityRepository : IAbilityRepository
    {
        private GladiatorTycoonDataContext _context;

        public AbilityRepository(GladiatorTycoonDataContext context)
        {
            _context = context;
        }

        private IQueryable<AbilityEntity> BaseQuery()
        {
            return _context.Ability;
        }

        public AbilityEntity Create(AbilityEntity abilityEntity)
        {
            _context.Ability.Add(abilityEntity);
            _context.SaveChanges();
            return abilityEntity;
        }

        public bool DeleteById(int id)
        {
            var ability = GetById(id);
            if (ability == null) { return false; }

            _context.Ability.Remove(ability);
            _context.SaveChanges();

            return true;
        }

        public List<AbilityEntity> GetAll()
        {
            return BaseQuery().ToList();
        }

        public AbilityEntity GetById(int id)
        {
            var ability = BaseQuery()
                .FirstOrDefault(u => u.Id == id);

            return ability;
        }

        public AbilityEntity Update(AbilityEntity abilityEntity)
        {
            _context.Ability.Attach(abilityEntity);
            _context.Entry(abilityEntity).State = EntityState.Modified;
            _context.SaveChanges();

            return abilityEntity;
        }
    }
}
