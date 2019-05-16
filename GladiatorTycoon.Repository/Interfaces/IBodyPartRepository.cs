using GladiatorTycoon.Entities;
using System.Collections.Generic;

namespace GladiatorTycoon.Repositories.Interfaces
{
    public interface IBodyPartRepository
    {
        RaceBodyPartEntity Create(RaceBodyPartEntity bodyPartEntity);
        RaceBodyPartEntity Update(RaceBodyPartEntity bodyPartEntity);
        bool DeleteById(int id);
        RaceBodyPartEntity GetById(int id);
        List<RaceBodyPartEntity> GetAll();
    }
}
