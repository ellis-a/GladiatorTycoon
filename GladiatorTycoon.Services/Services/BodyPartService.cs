using GladiatorTycoon.Entities;
using GladiatorTycoon.Repositories.Interfaces;
using GladiatorTycoon.Services.Models;
using System.Collections.Generic;
using System.Linq;

namespace GladiatorTycoon.Services.Services
{
    public class BodyPartService
    {
        private IBodyPartRepository _bodyPartRepository;

        public BodyPartService(IBodyPartRepository bodyPartRepository)
        {
            _bodyPartRepository = bodyPartRepository;
        }

        public BodyPartService()
        {
        }

        public BodyPart EntityToBodyPart(BodyPartEntity bodyPartEntity)
        {
            return new BodyPart()
            {
                Id = bodyPartEntity.Id,
                Name = bodyPartEntity.Name,
                DevName = bodyPartEntity.DevName,
                AvailableActions = bodyPartEntity.AvailableActions,
                BodyPartType = bodyPartEntity.BodyPartType,
                RequiredForLiving = bodyPartEntity.RequiredForLiving
            };
        }

        public BodyPartEntity BodyPartToEntity(BodyPart bodyPart)
        {
            return new BodyPartEntity()
            {
                Id = bodyPart.Id,
                Name = bodyPart.Name,
                DevName = bodyPart.DevName,
                AvailableActions = bodyPart.AvailableActions,
                BodyPartType = bodyPart.BodyPartType,
                RequiredForLiving = bodyPart.RequiredForLiving
            };
        }

        public BodyPart GetById(int id)
        {
            var bodyPart = _bodyPartRepository.GetById(id);
            return EntityToBodyPart(bodyPart);
        }

        public List<BodyPart> GetAll()
        {
            var bodyPartEntities = _bodyPartRepository.GetAll();
            var bodyParts = bodyPartEntities.Select(r => EntityToBodyPart(r)).ToList();
            return bodyParts;
        }

        public BodyPart Create(BodyPart bodyPart)
        {
            var bodyPartEntity = _bodyPartRepository.Create(BodyPartToEntity(bodyPart));
            return EntityToBodyPart(bodyPartEntity);
        }

        public BodyPart Update(BodyPart bodyPart)
        {
            var bodyPartEntity = _bodyPartRepository.GetById(bodyPart.Id);

            bodyPartEntity.Id = bodyPart.Id;
            bodyPartEntity.Name = bodyPart.Name;
            bodyPartEntity.DevName = bodyPart.DevName;
            bodyPartEntity.BodyPartType = bodyPart.BodyPartType;
            bodyPartEntity.AvailableActions = bodyPart.AvailableActions;
            bodyPartEntity.RequiredForLiving = bodyPart.RequiredForLiving;

            _bodyPartRepository.Update(bodyPartEntity);

            return EntityToBodyPart(bodyPartEntity);
        }

        public bool Delete(BodyPart bodyPart)
        {
            return _bodyPartRepository.DeleteById(bodyPart.Id);
        }
    }
}
