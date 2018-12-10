using System;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Models
{
    public class Slave : Person
    {
        public int? Loyalty { get; set; }
        public Dominus Owner { get; set; }

        public Slave()
        {

        }

        public Slave(Person person, int loyalty, Dominus dominus)
        {
            Agility = person.Agility;
            Charisma = person.Charisma;
            Dislikes = person.Dislikes;
            FirstName = person.FirstName;
            Gold = person.Gold;
            HomeCity = person.HomeCity;
            Id = person.Id;
            Intelligence = person.Intelligence;
            IsAlive = person.IsAlive;
            IsMale = person.IsMale;
            LastName = person.LastName;
            Likes = person.Likes;
            PlayerFacingAttitudes = person.PlayerFacingAttitudes;
            Race = person.Race;
            SocialStatus = person.SocialStatus;
            Strength = person.Strength;

            Loyalty = loyalty;
            Owner = dominus;
        }
    }
}
