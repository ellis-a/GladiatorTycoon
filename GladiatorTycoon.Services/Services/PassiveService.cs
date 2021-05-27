﻿using Entities;
using Repositories.Interfaces;
using Services.Models;

namespace Services.Services
{
    public class PassiveService
    {
        private IPassiveRepository _passiveRepository;

        public PassiveService() { }

        public PassiveService(IPassiveRepository passiveRepository)
        {
            _passiveRepository = passiveRepository;
        }

        public Passive EntityToPassive(PassiveEntity passiveEntity)
        {
            return new Passive()
            {
                Id = passiveEntity.Id
            };
        }

        public PassiveEntity PassiveToEntity(Passive passive)
        {
            return new PassiveEntity()
            {
                Id = passive.Id
            };
        }
    }
}
