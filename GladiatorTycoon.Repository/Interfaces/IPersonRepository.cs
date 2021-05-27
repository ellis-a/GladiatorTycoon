using Entities;
using System.Collections.Generic;

namespace Repositories.Interfaces
{
    public interface IPersonRepository
    {
        PersonEntity Create(PersonEntity personEntity);
        PersonEntity Update(PersonEntity personEntity);
        bool DeleteById(int id);
        PersonEntity GetById(int id);
        List<PersonEntity> GetAll();
    }
}
