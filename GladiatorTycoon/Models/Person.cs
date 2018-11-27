using GladiatorTycoon.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Models
{
    public class Person
    {
        public Person(string firstName, string lastName, SocialStatus socialStatus, Race race, bool isMale)
        {
            IsAlive = true;
            FirstName = firstName;
            LastName = lastName;
            SocialStatus = socialStatus;
            Race = race;
            IsMale = isMale;
            Gold = 0;
            Strength = 10;
            Intelligence = 10;
            Agility = 10;
            Charisma = 10;
        }

        public Person() { }

        [Key]
        public int Id { get; set; }

        public bool IsAlive { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Gold { get; set; }
        public SocialStatus SocialStatus { get; set; }
        public Race Race { get; set; }
        public bool IsMale { get; set; }
        public City HomeCity { get; set; }

        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }
        public int Charisma { get; set; }

        public Dictionary<Dominus, int> PlayerFacingAttitudes { get; set; }

        public List<Event> Likes { get; set; }
        public List<Event> Dislikes { get; set; }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
