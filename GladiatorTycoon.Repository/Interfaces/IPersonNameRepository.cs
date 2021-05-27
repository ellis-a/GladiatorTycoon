using Entities;
using System.Collections.Generic;

namespace Repositories.Interfaces
{
    public interface IPersonNameRepository
    {
        PersonNameEntity Create(PersonNameEntity bodyPartEntity);
        PersonNameEntity Update(PersonNameEntity bodyPartEntity);
        bool DeleteById(int id);
        PersonNameEntity GetById(int id);
        List<PersonNameEntity> GetAll();
    }
}
