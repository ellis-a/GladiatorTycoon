using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Models
{
    public class Dominus : Person
    {
        public List<Gladiator> Gladiators { get; set; }
        public List<Slave> Slaves { get; set; }
        public List<Item> Inventory { get; set; }

        public List<House> Homes { get; set; }

        public Dominus()
        {

        }

        public Dominus(Person person)
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
        }
    }
}
