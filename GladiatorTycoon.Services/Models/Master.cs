using System.Collections.Generic;

namespace GladiatorTycoon.Services.Models
{
    public class Master : Person
    {
        public List<Item> Inventory { get; set; }
        public List<House> Homes { get; set; }

        public Master()
        {

        }

        public Master(Person person)
        {
            Skill = person.Skill;
            Charisma = person.Charisma;
            FirstName = person.FirstName;
            Gold = person.Gold;
            HomeCity = person.HomeCity;
            Id = person.Id;
            Wits = person.Wits;
            IsAlive = person.IsAlive;
            Gender = person.Gender;
            LastName = person.LastName;
            Race = person.Race;
            SocialStatus = person.SocialStatus;
            Power = person.Power;
        }
    }
}
