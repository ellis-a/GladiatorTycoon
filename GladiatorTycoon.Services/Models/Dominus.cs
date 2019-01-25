using System.Collections.Generic;

namespace GladiatorTycoon.Services.Models
{
    public class Dominus : Person
    {
        public List<Item> Inventory { get; set; }
        public List<House> Homes { get; set; }

        public Dominus()
        {

        }

        public Dominus(Person person)
        {
            Speed = person.Speed;
            Charisma = person.Charisma;
            FirstName = person.FirstName;
            Gold = person.Gold;
            HomeCity = person.HomeCity;
            Id = person.Id;
            Wits = person.Wits;
            IsAlive = person.IsAlive;
            IsMale = person.IsMale;
            LastName = person.LastName;
            Race = person.Race;
            SocialStatus = person.SocialStatus;
            Power = person.Power;
        }
    }
}
