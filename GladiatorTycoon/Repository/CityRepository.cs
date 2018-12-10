using GladiatorTycoon.Enums;
using GladiatorTycoon.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GladiatorTycoon.Repository
{
    public class CityRepository : BaseRepository
    {
        protected List<City> ConvertToCityList(DataTable dataTable)
        {
            var convertedList = (from row in dataTable.AsEnumerable()
                                 select new City()
                                 {
                                     Id = (int) row["Id"],
                                     Name = (string) row["Name"],
                                     Habitat = (Habitat) row["Habitat"],
                                     //arenas
                                 }).ToList();

            return convertedList;
        }

        public List<City> GetCitiesByQuery(string query)
        {
            var dataTable = GetData(query);
            var cities = ConvertToCityList(dataTable);
            return cities;
        }

        public List<City> GetAllCities()
        {
            string query = "SELECT * FROM cities";
            var cities = GetCitiesByQuery(query);
            return cities;
        }

        public City GetCityById(int id)
        {
            string query = $"SELECT * FROM cities WHERE Id = {id}";
            var city = GetCitiesByQuery(query).FirstOrDefault();
            return city;
        }
    }
}
