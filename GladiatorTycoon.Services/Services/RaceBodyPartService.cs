using GladiatorTycoon.Entities;
using GladiatorTycoon.Repositories.Interfaces;
using GladiatorTycoon.Services.Models;
using System.Collections.Generic;
using System.Linq;

namespace GladiatorTycoon.Services.Services
{
    public class RaceBodyPartService
    {
        private IBodyPartRepository _bodyPartRepository;

        public RaceBodyPartService(IBodyPartRepository bodyPartRepository)
        {
            _bodyPartRepository = bodyPartRepository;
        }

        public RaceBodyPartService()
        {
        }

        public RaceBodyPart EntityToBodyPart(RaceBodyPartEntity bodyPartEntity)
        {
            return new RaceBodyPart()
            {
                Id = bodyPartEntity.Id,
                Name = bodyPartEntity.Name,
                DevName = bodyPartEntity.DevName,
                AvailableActions = bodyPartEntity.AvailableActions,
                BodyPartType = bodyPartEntity.BodyPartType,
                IsVital = bodyPartEntity.IsVital
            };
        }

        public RaceBodyPartEntity BodyPartToEntity(RaceBodyPart bodyPart)
        {
            return new RaceBodyPartEntity()
            {
                Id = bodyPart.Id,
                Name = bodyPart.Name,
                DevName = bodyPart.DevName,
                AvailableActions = bodyPart.AvailableActions,
                BodyPartType = bodyPart.BodyPartType,
                IsVital = bodyPart.IsVital
            };
        }

        public RaceBodyPart GetById(int id)
        {
            var bodyPart = _bodyPartRepository.GetById(id);
            return EntityToBodyPart(bodyPart);
        }

        public List<RaceBodyPart> GetAll()
        {
            var bodyPartEntities = _bodyPartRepository.GetAll();
            var bodyParts = bodyPartEntities.Select(r => EntityToBodyPart(r)).ToList();
            return bodyParts;
        }

        public RaceBodyPart Create(RaceBodyPart bodyPart)
        {
            var bodyPartEntity = _bodyPartRepository.Create(BodyPartToEntity(bodyPart));
            return EntityToBodyPart(bodyPartEntity);
        }

        public RaceBodyPart Update(RaceBodyPart bodyPart)
        {
            var bodyPartEntity = _bodyPartRepository.GetById(bodyPart.Id);

            bodyPartEntity.Id = bodyPart.Id;
            bodyPartEntity.Name = bodyPart.Name;
            bodyPartEntity.DevName = bodyPart.DevName;
            bodyPartEntity.BodyPartType = bodyPart.BodyPartType;
            bodyPartEntity.AvailableActions = bodyPart.AvailableActions;
            bodyPartEntity.IsVital = bodyPart.IsVital;

            _bodyPartRepository.Update(bodyPartEntity);

            return EntityToBodyPart(bodyPartEntity);
        }

        public bool Delete(RaceBodyPart bodyPart)
        {
            return _bodyPartRepository.DeleteById(bodyPart.Id);
        }
    }
}
