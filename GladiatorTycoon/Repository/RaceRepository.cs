using GladiatorTycoon.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GladiatorTycoon.Repository
{
    public class RaceRepository : BaseRepository<Race>
    {
        private List<Race> ConvertToRaceList(DataTable dataTable)
        {
            var convertedList = (from row in dataTable.AsEnumerable()
                                 select new Race()
                                 {
                                     Id = (int) row["Id"],
                                     Name = (string) row["Name"],
                                     PositiveHabitats = (string) row["PositiveHabitats"],
                                     NegativeHabitats = (string) row["NegativeHabitats"],
                                     //racials
                                 }).ToList();

            return convertedList;
        }

        public List<Race> GetRacesByQuery(string query)
        {
            var dataTable = GetData(query);
            var races = ConvertToRaceList(dataTable);
            return races;
        }

        public List<Race> GetAllRaces()
        {
            string query = "SELECT * FROM races";
            var races = GetRacesByQuery(query);
            return races;
        }

        public Race GetRaceById(int id)
        {
            string query = $"SELECT * FROM races WHERE Id = {id}";
            var race = GetRacesByQuery(query).FirstOrDefault();
            return race;
        }
    }
}
