using Entities;
using System.Collections.Generic;

namespace Repositories.Interfaces
{
    public interface IRaceRepository
    {
        RaceEntity Create(RaceEntity raceEntity);
        RaceEntity Update(RaceEntity raceEntity);
        bool DeleteById(int id);
        RaceEntity GetById(int id);
        List<RaceEntity> GetAll();
    }
}
