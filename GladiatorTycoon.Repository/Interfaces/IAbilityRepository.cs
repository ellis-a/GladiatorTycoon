using GladiatorTycoon.Entities;
using System.Collections.Generic;

namespace GladiatorTycoon.Repositories.Interfaces
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
