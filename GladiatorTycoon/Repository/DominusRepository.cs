using GladiatorTycoon.Models;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GladiatorTycoon.Repository
{
    public class DominusRepository : PersonRepository
    {
        protected List<Dominus> ConvertToDominusList(DataTable dataTable)
        {
            var raceRepo = new RaceRepository();
            var cityRepo = new CityRepository();
            var races = raceRepo.GetAllRaces();
            var cities = cityRepo.GetAllCities();

            var persons = GetPersonObjects(dataTable, races, cities);

            var dominii = new List<Dominus>();
            foreach (var person in persons)
            {
                dominii.Add(new Dominus(person));
            }

            return dominii;
        }

        public List<Dominus> GetDominiiByQuery(string query)
        {
            var dataTable = GetData(query);
            var persons = ConvertToDominusList(dataTable);
            return persons;
        }

        public List<Dominus> GetAllDominii()
        {
            var query = "SELECT * FROM people WHERE SocialStatus <> 0";
            var slaves = GetDominiiByQuery(query);
            return slaves;
        }

        public void SaveDominii(List<Dominus> dominii)
        {
            StringBuilder query = new StringBuilder();
            foreach (var dominus in dominii)
            {
                if (dominus.Id > 0)
                {
                    //query.AppendLine($@"UPDATE people
                    //        SET IsAlive = '{(dominus.IsAlive ? 1 : 0)}', FirstName = '{dominus.FirstName}', LastName = '{dominus.LastName}', Gold = '{dominus.Gold}', SocialStatus = '{(int)dominus.SocialStatus}', IsMale = '{(dominus.IsMale ? 1 : 0)}', Strength = '{dominus.Strength}', Intelligence = '{dominus.Intelligence}', Agility = '{dominus.Agility}', Charisma = '{dominus.Charisma}', HomeCity_Id = {(dominus.HomeCity != null ? dominus.HomeCity.Id.ToString() : "NULL")}, Race_Id = {(dominus.Race != null ? dominus.Race.Id.ToString() : "NULL")}
                    //        WHERE Id = '{dominus.Id}';");
                }
                else
                {
                    //query.AppendLine($@"INSERT INTO people (IsAlive, FirstName, LastName, Gold, SocialStatus, IsMale, Strength, Intelligence, Agility, Charisma, HomeCity_Id, Race_Id)
                    //        VALUES ('{(dominus.IsAlive ? 1 : 0)}', '{dominus.FirstName}', '{dominus.LastName}', '{dominus.Gold}', '{(int)dominus.SocialStatus}', '{(dominus.IsMale ? 1 : 0)}', '{dominus.Strength}', '{dominus.Intelligence}', '{dominus.Agility}', '{dominus.Charisma}', {(dominus.HomeCity != null ? dominus.HomeCity.Id.ToString() : "NULL")}, {(dominus.Race != null ? dominus.Race.Id.ToString() : "NULL")});");
                }
            }
            SaveData(query.ToString());
        }
    }
}
