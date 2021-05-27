using Entities;
using System.Collections.Generic;

namespace Repositories.Interfaces
{
    public interface IAbilityRepository
    {
        AbilityEntity Create(AbilityEntity abilityEntity);
        AbilityEntity Update(AbilityEntity abilityEntity);
        bool DeleteById(int id);
        AbilityEntity GetById(int id);
        List<AbilityEntity> GetAll();
    }
}
