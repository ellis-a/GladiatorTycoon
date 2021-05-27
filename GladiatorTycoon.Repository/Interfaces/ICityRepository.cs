using Entities;
using System.Collections.Generic;

namespace Repositories.Interfaces
{
    public interface ICityRepository
    {
        CityEntity Create(CityEntity cityEntity);
        CityEntity Update(CityEntity cityEntity);
        bool DeleteById(int id);
        CityEntity GetById(int id);
        List<CityEntity> GetAll();
    }
}
