using Entities;
using System.Collections.Generic;

namespace Repositories.Interfaces
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
