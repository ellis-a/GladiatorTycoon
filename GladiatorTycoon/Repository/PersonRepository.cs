using GladiatorTycoon.Enums;
using GladiatorTycoon.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GladiatorTycoon.Repository
{
    public class PersonRepository : BaseRepository<Person>
    {
        private List<Person> ConvertToPersonList(DataTable dataTable)
        {
            var raceRepo = new RaceRepository();
            var races = raceRepo.GetAllRaces();

            var convertedList = (from row in dataTable.AsEnumerable()
                                 select new Person()
                                 {
                                     Id = (int) row["Id"],
                                     IsAlive = (bool) row["IsAlive"],
                                     FirstName = (string) row["FirstName"],
                                     LastName = (string) row["LastName"],
                                     Gold = (int) row["Gold"],
                                     SocialStatus = (SocialStatus) row["SocialStatus"],
                                     IsMale = (bool) row["IsMale"],
                                     Strength = (int) row["Strength"],
                                     Intelligence = (int) row["Intelligence"],
                                     Agility = (int) row["Agility"],
                                     Charisma = (int) row["Charisma"],
                                     Race = races?.FirstOrDefault(r => r.Id == (int) row["Race_Id"]),
                                     //Likes = (int) row["Likes"],
                                     //Dislikes = (int) row["Gold"],
                                     //HomeCity = (int) row["Gold"],
                                     //PlayerFacingAttitudes = (int) row["Gold"],
                                 }).ToList();

            return convertedList;
        }

        public List<Person> GetPersonsByQuery(string query)
        {
            var dataTable = GetData(query);
            var persons = ConvertToPersonList(dataTable);
            return persons;
        }

        public List<Person> GetAllPersons()
        {
            string query = "SELECT * FROM people";
            var persons = GetPersonsByQuery(query);
            return persons;
        }
    }
}
