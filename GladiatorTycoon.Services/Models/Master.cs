using System.Collections.Generic;

namespace Services.Models
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
            BaseSkill = person.BaseSkill;
            BaseCharisma = person.BaseCharisma;
            FirstName = person.FirstName;
            Gold = person.Gold;
            HomeCity = person.HomeCity;
            Id = person.Id;
            BaseWits = person.BaseWits;
            IsAlive = person.IsAlive;
            Gender = person.Gender;
            LastName = person.LastName;
            Race = person.Race;
            SocialStatus = person.SocialStatus;
            BasePower = person.BasePower;
        }
    }
}
