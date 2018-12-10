using GladiatorTycoon.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GladiatorTycoon.Repository
{
    public class RaceRepository : BaseRepository
    {
        protected List<Race> ConvertToRaceList(DataTable dataTable)
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

        public void SaveRaces(List<Race> races)
        {
            StringBuilder query = new StringBuilder();
            foreach (var race in races)
            {
                if (race.Id > 0)
                {
                    query.AppendLine($@"UPDATE races
                            SET Name = '{race.Name}', PositiveHabitats = '{race.PositiveHabitats}', NegativeHabitats = '{race.NegativeHabitats}'
                            WHERE Id = '{race.Id}';");
                }
                else
                {
                    query.AppendLine($@"INSERT INTO races (Name, PositiveHabitats, NegativeHabitats)
                            VALUES ('{race.Name}', '{race.PositiveHabitats}', '{race.NegativeHabitats}');");
                }
            }
            SaveData(query.ToString());
        }
    }
}
