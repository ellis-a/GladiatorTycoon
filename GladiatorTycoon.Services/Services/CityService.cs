using Entities;
using Repositories.Interfaces;
using Services.Models;
using System.Collections.Generic;
using System.Linq;

namespace Services.Services
{
    public class CityService
    {
        private ICityRepository _cityRepository;

        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public CityService()
        {
        }

        public City EntityToCity(CityEntity cityEntity)
        {
            if (cityEntity == null)
            {
                return null;
            }

            return new City()
            {
                Id = cityEntity.Id,
                Name = cityEntity.Name,
                Habitat = cityEntity.Habitat,
            };
        }

        public CityEntity CityToEntity(City city)
        {
            if (city == null)
            {
                return null;
            }

            return new CityEntity()
            {
                Id = city.Id,
                Name = city.Name,
                Habitat = city.Habitat
            };
        }

        public City GetById(int id)
        {
            var city = _cityRepository.GetById(id);
            return EntityToCity(city);
        }

        public List<City> GetAll()
        {
            var cityEntities = _cityRepository.GetAll();
            var cities = cityEntities.Select(r => EntityToCity(r)).ToList();
            return cities;
        }

        public City Create(City city)
        {
            var cityEntity = _cityRepository.Create(CityToEntity(city));
            return EntityToCity(cityEntity);
        }

        public City Update(City city)
        {
            var cityEntity = _cityRepository.GetById(city.Id);

            cityEntity.Id = city.Id;
            cityEntity.Name = city.Name;
            cityEntity.Habitat = city.Habitat;

            _cityRepository.Update(cityEntity);

            return EntityToCity(cityEntity);
        }

        public bool Delete(City city)
        {
            return _cityRepository.DeleteById(city.Id);
        }

    }
}
