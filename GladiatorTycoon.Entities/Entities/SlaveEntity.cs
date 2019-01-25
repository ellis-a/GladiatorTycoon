using System;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Entities
{
    public class SlaveEntity : PersonEntity
    {
        public int? Loyalty { get; set; }
        public DominusEntity Owner { get; set; }

        public SlaveEntity()
        {

        }

        public SlaveEntity(PersonEntity person, int loyalty, DominusEntity dominus)
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

            Loyalty = loyalty;
            Owner = dominus;
        }
    }
}
