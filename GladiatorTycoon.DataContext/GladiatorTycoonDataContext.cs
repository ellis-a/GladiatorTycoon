﻿using Entities;
using System.Data.Entity;

namespace DataContext
{
    public class GladiatorTycoonDataContext : DbContext
    {
        public DbSet<AbilityEntity> Ability { get; set; }
        public DbSet<AfflictionEntity> Affliction { get; set; }
        public DbSet<ArenaEntity> Arena { get; set; }
        public DbSet<ArmourEntity> Armour { get; set; }
        public DbSet<CityEntity> City { get; set; }
        public DbSet<CombatClassEntity> Class { get; set; }
        public DbSet<DeityEntity> Deity { get; set; }
        public DbSet<MasterEntity> Dominus { get; set; }
        public DbSet<HouseEntity> House { get; set; }
        public DbSet<ItemEntity> Item { get; set; }
        public DbSet<MerchantEntity> Merchant { get; set; }
        public DbSet<PartyEntity> Party { get; set; }
        public DbSet<PassiveEntity> Passive { get; set; }
        public DbSet<PersonNameEntity> PersonName { get; set; }
        public DbSet<PersonEntity> Person { get; set; }
        public DbSet<RaceEntity> Race { get; set; }
        public DbSet<SlaveEntity> Slave { get; set; }
        public DbSet<WeaponEntity> Weapon { get; set; }

        public GladiatorTycoonDataContext() : this("connectionString")
        {

        }

        public GladiatorTycoonDataContext(string connectionString) : base(connectionString)
        {

        }
    }
}
