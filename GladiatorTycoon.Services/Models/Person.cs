using Enums;
using Helper;
using Services.Services;
using System;
using System.Linq;

namespace Services.Models
{
    public class Person
    {
        public int Id { get; set; }

        public bool IsAlive { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Gold { get; set; }
        public SocialStatus SocialStatus { get; set; }
        public Race Race { get; set; }
        public Gender Gender { get; set; }
        public City HomeCity { get; set; }

        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }

        public int BasePower { get; set; }
        public int BaseWits { get; set; }
        public int BaseSkill { get; set; }
        public int BaseCharisma { get; set; }
        public int BaseBravery { get; set; }
        public int Speed { get; set; }
        public int Popularity { get; set; }

        public Person(string firstName, string lastName, SocialStatus socialStatus, Race race, Gender gender)
        {
            IsAlive = true;
            FirstName = firstName;
            LastName = lastName;
            SocialStatus = socialStatus;
            Race = race;
            Gender = gender;
            Gold = 0;
            BasePower = 10;
            BaseWits = 10;
            BaseSkill = 10;
            BaseCharisma = 10;
        }

        public Person()
        {

        }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }

        public override string ToString()
        {
            return FullName();
        }
    }
}
