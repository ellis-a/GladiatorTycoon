using GladiatorTycoon.Entities;
using System.Collections.Generic;

namespace GladiatorTycoon.Repositories.Interfaces
{
    public interface IPassiveRepository
    {
        PassiveEntity Create(PassiveEntity passiveEntity);
        PassiveEntity Update(PassiveEntity passiveEntity);
        bool DeleteById(int id);
        PassiveEntity GetById(int id);
        List<PassiveEntity> GetAll();
    }
}
