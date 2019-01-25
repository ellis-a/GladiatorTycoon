namespace GladiatorTycoon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abilities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Afflictions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cure = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Passives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AfflictionEntity_Id = c.Int(),
                        ClassEntity_Id = c.Int(),
                        RaceEntity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Afflictions", t => t.AfflictionEntity_Id)
                .ForeignKey("dbo.Classes", t => t.ClassEntity_Id)
                .ForeignKey("dbo.Races", t => t.RaceEntity_Id);
            
            CreateTable(
                "dbo.Arenas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        City_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Habitat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GoldCost = c.Int(nullable: false),
                        MaxDurability = c.Int(nullable: false),
                        CurrentDurability = c.Int(nullable: false),
                        MasterEntity_Id = c.Int(),
                        GladiatorEntity_Id1 = c.Int(),
                        MerchantEntity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Masters", t => t.MasterEntity_Id)
                .ForeignKey("dbo.Gladiators", t => t.GladiatorEntity_Id1)
                .ForeignKey("dbo.Merchants", t => t.MerchantEntity_Id);
            
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Deities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Persons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsAlive = c.Boolean(nullable: false),
                        FirstName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        Gold = c.Int(nullable: false),
                        SocialStatus = c.Int(nullable: false),
                        IsMale = c.Boolean(nullable: false),
                        Power = c.Int(nullable: false),
                        Wits = c.Int(nullable: false),
                        Speed = c.Int(nullable: false),
                        Charisma = c.Int(nullable: false),
                        HomeCity_Id = c.Int(),
                        Race_Id = c.Int(),
                        PartyEntity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.HomeCity_Id)
                .ForeignKey("dbo.Races", t => t.Race_Id)
                .ForeignKey("dbo.Parties", t => t.PartyEntity_Id);
            
            CreateTable(
                "dbo.Houses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PeopleCapacity = c.Int(nullable: false),
                        Value = c.Int(nullable: false),
                        Location_Id = c.Int(),
                        MasterEntity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.Location_Id)
                .ForeignKey("dbo.Masters", t => t.MasterEntity_Id);
            
            CreateTable(
                "dbo.Races",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        PositiveHabitats = c.String(unicode: false),
                        NegativeHabitats = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Parties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SuccessScore = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Armours",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        GladiatorEntity_Id = c.Int(),
                        Defense = c.Int(nullable: false),
                        ArmourSlot = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.Id)
                .ForeignKey("dbo.Gladiators", t => t.GladiatorEntity_Id);
            
            CreateTable(
                "dbo.Masters",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Persons", t => t.Id);
            
            CreateTable(
                "dbo.Slaves",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Owner_Id = c.Int(),
                        Loyalty = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Persons", t => t.Id)
                .ForeignKey("dbo.Masters", t => t.Owner_Id);
            
            CreateTable(
                "dbo.Gladiators",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        MaxHealth = c.Int(nullable: false),
                        CurrentHealth = c.Int(nullable: false),
                        Offense = c.Int(nullable: false),
                        Defense = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Slaves", t => t.Id);
            
            CreateTable(
                "dbo.Merchants",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Persons", t => t.Id);
            
            CreateTable(
                "dbo.Weapons",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        GladiatorEntity_Id = c.Int(),
                        Offense = c.Int(nullable: false),
                        WeaponType = c.Int(nullable: false),
                        IsTwoHander = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.Id)
                .ForeignKey("dbo.Gladiators", t => t.GladiatorEntity_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Weapons", "GladiatorEntity_Id", "dbo.Gladiators");
            DropForeignKey("dbo.Weapons", "Id", "dbo.Items");
            DropForeignKey("dbo.Merchants", "Id", "dbo.Persons");
            DropForeignKey("dbo.Gladiators", "Id", "dbo.Slaves");
            DropForeignKey("dbo.Slaves", "Owner_Id", "dbo.Masters");
            DropForeignKey("dbo.Slaves", "Id", "dbo.Persons");
            DropForeignKey("dbo.Masters", "Id", "dbo.Persons");
            DropForeignKey("dbo.Armours", "GladiatorEntity_Id", "dbo.Gladiators");
            DropForeignKey("dbo.Armours", "Id", "dbo.Items");
            DropForeignKey("dbo.Persons", "PartyEntity_Id", "dbo.Parties");
            DropForeignKey("dbo.Persons", "Race_Id", "dbo.Races");
            DropForeignKey("dbo.Persons", "HomeCity_Id", "dbo.Cities");
            DropForeignKey("dbo.Items", "MerchantEntity_Id", "dbo.Merchants");
            DropForeignKey("dbo.Items", "GladiatorEntity_Id1", "dbo.Gladiators");
            DropForeignKey("dbo.Passives", "RaceEntity_Id", "dbo.Races");
            DropForeignKey("dbo.Items", "MasterEntity_Id", "dbo.Masters");
            DropForeignKey("dbo.Houses", "MasterEntity_Id", "dbo.Masters");
            DropForeignKey("dbo.Houses", "Location_Id", "dbo.Cities");
            DropForeignKey("dbo.Passives", "ClassEntity_Id", "dbo.Classes");
            DropForeignKey("dbo.Arenas", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Passives", "AfflictionEntity_Id", "dbo.Afflictions");
            DropTable("dbo.Weapons");
            DropTable("dbo.Merchants");
            DropTable("dbo.Gladiators");
            DropTable("dbo.Slaves");
            DropTable("dbo.Masters");
            DropTable("dbo.Armours");
            DropTable("dbo.Parties");
            DropTable("dbo.Races");
            DropTable("dbo.Houses");
            DropTable("dbo.Persons");
            DropTable("dbo.Deities");
            DropTable("dbo.Classes");
            DropTable("dbo.Items");
            DropTable("dbo.Cities");
            DropTable("dbo.Arenas");
            DropTable("dbo.Passives");
            DropTable("dbo.Afflictions");
            DropTable("dbo.Abilities");
        }
    }
}
