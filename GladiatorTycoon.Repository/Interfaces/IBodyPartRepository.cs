using GladiatorTycoon.Entities;
using System.Collections.Generic;

namespace GladiatorTycoon.Repositories.Interfaces
{
    public interface IBodyPartRepository
    {
        BodyPartEntity Create(BodyPartEntity bodyPartEntity);
        BodyPartEntity Update(BodyPartEntity bodyPartEntity);
        bool DeleteById(int id);
        BodyPartEntity GetById(int id);
        List<BodyPartEntity> GetAll();
    }
}
