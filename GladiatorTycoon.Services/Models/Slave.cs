namespace Services.Models
{
    public class Slave : Person
    {
        public int? Loyalty { get; set; }
        public Master Owner { get; set; }

        public Slave()
        {

        }

        public Slave(Person person, int loyalty, Master dominus)
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

            Loyalty = loyalty;
            Owner = dominus;
        }
    }
}
