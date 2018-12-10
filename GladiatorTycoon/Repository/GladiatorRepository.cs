using GladiatorTycoon.Enums;
using GladiatorTycoon.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GladiatorTycoon.Repository
{
    public class GladiatorRepository : SlaveRepository
    {
        protected List<Gladiator> ConvertToGladiatorList(DataTable dataTable)
        {
            var raceRepo = new RaceRepository();
            var cityRepo = new CityRepository();
            var races = raceRepo.GetAllRaces();
            var cities = cityRepo.GetAllCities();



            var convertedList = (from row in dataTable.AsEnumerable()
                                 select new Gladiator()
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
                                     HomeCity = cities?.FirstOrDefault(c => c.Id == (int) row["HomeCity_Id"]),
                                     CurrentHealth = (int)row["CurrentHealth"],
                                     MaxHealth = (int)row["MaxHealth"],
                                     //a = (int)row["Charisma"],
                                     //Likes = (int) row["Likes"],
                                     //Dislikes = (int) row["Gold"],
                                     //PlayerFacingAttitudes = (int) row["Gold"],
                                 }).ToList();

            return convertedList;
        }

        public List<Gladiator> GetGladiatorsByQuery(string query)
        {
            var dataTable = GetData(query);
            var persons = ConvertToGladiatorList(dataTable);
            return persons;
        }

        public List<Gladiator> GetAllGladiators()
        {
            var query = "SELECT * FROM people";
            var gladiators = GetGladiatorsByQuery(query);
            return gladiators;
        }

        public void SaveGladiators(List<Gladiator> gladiators)
        {
            StringBuilder query = new StringBuilder();
            foreach (var person in gladiators)
            {
                if (person.Id > 0)
                {
                    query.AppendLine($@"UPDATE people
                            SET IsAlive = '{(person.IsAlive ? 1 : 0)}', FirstName = '{person.FirstName}', LastName = '{person.LastName}', Gold = '{person.Gold}', SocialStatus = '{(int)person.SocialStatus}', IsMale = '{(person.IsMale ? 1 : 0)}', Strength = '{person.Strength}', Intelligence = '{person.Intelligence}', Agility = '{person.Agility}', Charisma = '{person.Charisma}', HomeCity_Id = {(person.HomeCity != null ? person.HomeCity.Id.ToString() : "NULL")}, Race_Id = {(person.Race != null ? person.Race.Id.ToString() : "NULL")}
                            WHERE Id = '{person.Id}';");
                }
                else
                {
                    query.AppendLine($@"INSERT INTO people (IsAlive, FirstName, LastName, Gold, SocialStatus, IsMale, Strength, Intelligence, Agility, Charisma, HomeCity_Id, Race_Id)
                            VALUES ('{(person.IsAlive ? 1 : 0)}', '{person.FirstName}', '{person.LastName}', '{person.Gold}', '{(int)person.SocialStatus}', '{(person.IsMale ? 1 : 0)}', '{person.Strength}', '{person.Intelligence}', '{person.Agility}', '{person.Charisma}', {(person.HomeCity != null ? person.HomeCity.Id.ToString() : "NULL")}, {(person.Race != null ? person.Race.Id.ToString() : "NULL")});");
                }
            }
            SaveData(query.ToString());
        }
    }
}
