using System.Data.Entity;
using MySql.Data.Entity;
using GladiatorTycoon.Models;

namespace GladiatorTycoon.Context
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class GladiatorTycoonContext : DbContext
    {
        //Add Dbsets here  
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<Affliction> Afflictions { get; set; }
        public DbSet<Arena> Arenas { get; set; }
        public DbSet<Armour> Armours { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Deity> Deities { get; set; }
        public DbSet<Dominus> Dominii { get; set; }
        public DbSet<Effect> Effects { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Gladiator> Gladiators { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Party> Parties { get; set; }
        public DbSet<PassiveTrait> PassiveTraits { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Slave> Slaves { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

        public GladiatorTycoonContext() : base("connectionString") { }
    }
}
