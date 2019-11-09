using GladiatorTycoon.Enums;
using GladiatorTycoon.Helper;
using GladiatorTycoon.Services.Services;
using System;
using System.Linq;

namespace GladiatorTycoon.Services.Models
{
    public class Person
    {
        public Person(string firstName, string lastName, SocialStatus socialStatus, Race race, Gender gender)
        {
            IsAlive = true;
            FirstName = firstName;
            LastName = lastName;
            SocialStatus = socialStatus;
            Race = race;
            Gender = gender;
            Gold = 0;
            Power = 10;
            Wits = 10;
            Skill = 10;
            Charisma = 10;
        }

        public Person() { }

        public int Id { get; set; }

        public bool IsAlive { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Gold { get; set; }
        public SocialStatus SocialStatus { get; set; }
        public Race Race { get; set; }
        public Gender Gender { get; set; }
        public City HomeCity { get; set; }

        public int Power { get; set; }
        public int Wits { get; set; }
        public int Skill { get; set; }
        public int Charisma { get; set; }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
