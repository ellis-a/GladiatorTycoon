using GladiatorTycoon.Enums;
using GladiatorTycoon.Helpers;
using GladiatorTycoon.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GladiatorTycoon.Repository
{
    public class SlaveRepository : PersonRepository
    {
        protected List<Slave> ConvertToSlaveList(DataTable dataTable)
        {
            var raceRepo = new RaceRepository();
            var cityRepo = new CityRepository();
            var dominusRepo = new DominusRepository();
            var races = raceRepo.GetAllRaces();
            var cities = cityRepo.GetAllCities();
            var dominii = dominusRepo.GetAllDominii();

            var persons = GetPersonObjects(dataTable, races, cities);

            var slaves = new List<Slave>();
            foreach (var person in persons)
            {
                var domIdObj = dataTable.AsEnumerable().FirstOrDefault(d => (int)d["Id"] == person.Id)["Owner_Id"];
                var domId = DataChecking.IsNumber(domIdObj) ? (int)domIdObj : 0;
                var dominus = DataChecking.IsNumber(domIdObj) ? dominii.FirstOrDefault(d => d.Id == domId) : null;
                var loyaltyObj = dataTable.AsEnumerable().FirstOrDefault(d => (int)d["Id"] == person.Id)["Loyalty"];
                var loyalty = DataChecking.IsNumber(loyaltyObj) ? (int)loyaltyObj : 0;
                slaves.Add(new Slave(person, loyalty, dominus));
            }

            return slaves;
        }

        public List<Slave> GetSlavesByQuery(string query)
        {
            var dataTable = GetData(query);
            var persons = ConvertToSlaveList(dataTable);
            return persons;
        }

        public List<Slave> GetAllSlaves()
        {
            var query = "SELECT * FROM people WHERE SocialStatus = 0";
            var slaves = GetSlavesByQuery(query);
            return slaves;
        }

        public void SavePersons(List<Slave> slaves)
        {
            StringBuilder query = new StringBuilder();
            foreach (var person in slaves)
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
