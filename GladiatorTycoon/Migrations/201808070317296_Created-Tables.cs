namespace GladiatorTycoon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedTables : DbMigration
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
                "dbo.Effects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ability_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Abilities", t => t.Ability_Id);
            
            CreateTable(
                "dbo.Afflictions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cure = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PassiveTraits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Affliction_Id = c.Int(),
                        Class_Id = c.Int(),
                        Race_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Afflictions", t => t.Affliction_Id)
                .ForeignKey("dbo.Classes", t => t.Class_Id)
                .ForeignKey("dbo.Races", t => t.Race_Id);
            
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
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GoldCost = c.Int(nullable: false),
                        MaxDurability = c.Int(nullable: false),
                        CurrentDurability = c.Int(nullable: false),
                        Toughness = c.Int(),
                        ArmourSlot = c.Int(),
                        Power = c.Int(),
                        WeaponType = c.Int(),
                        IsTwoHander = c.Boolean(),
                        Discriminator = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Gladiator_Id = c.Int(),
                        Gladiator_Id1 = c.Int(),
                        Gladiator_Id2 = c.Int(),
                        Dominus_Id = c.Int(),
                        Merchant_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Gladiator_Id)
                .ForeignKey("dbo.People", t => t.Gladiator_Id1)
                .ForeignKey("dbo.People", t => t.Gladiator_Id2)
                .ForeignKey("dbo.People", t => t.Dominus_Id)
                .ForeignKey("dbo.People", t => t.Merchant_Id);
            
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
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsAlive = c.Boolean(nullable: false),
                        FirstName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        Gold = c.Int(nullable: false),
                        SocialStatus = c.Int(nullable: false),
                        IsMale = c.Boolean(nullable: false),
                        Strength = c.Int(nullable: false),
                        Intelligence = c.Int(nullable: false),
                        Agility = c.Int(nullable: false),
                        Charisma = c.Int(nullable: false),
                        Loyalty = c.Int(),
                        MaxHealth = c.Int(),
                        CurrentHealth = c.Int(),
                        Power = c.Int(),
                        Toughness = c.Int(),
                        Dominus_Id = c.Int(),
                        Owner_Id = c.Int(),
                        HomeCity_Id = c.Int(),
                        Race_Id = c.Int(),
                        Party_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Dominus_Id)
                .ForeignKey("dbo.People", t => t.Owner_Id)
                .ForeignKey("dbo.Cities", t => t.HomeCity_Id)
                .ForeignKey("dbo.Races", t => t.Race_Id)
                .ForeignKey("dbo.Parties", t => t.Party_Id);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AffectedCity_Id = c.Int(),
                        AffectedHouse_Id = c.Int(),
                        LikedBy = c.Int(),
                        DislikedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.AffectedCity_Id)
                .ForeignKey("dbo.Houses", t => t.AffectedHouse_Id)
                .ForeignKey("dbo.People", t => t.LikedBy)
                .ForeignKey("dbo.People", t => t.DislikedBy);
            
            CreateTable(
                "dbo.Houses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PeopleCapacity = c.Int(nullable: false),
                        Location_Id = c.Int(),
                        Dominus_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.Location_Id)
                .ForeignKey("dbo.People", t => t.Dominus_Id);
            
            CreateTable(
                "dbo.Races",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
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
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Party_Id", "dbo.Parties");
            DropForeignKey("dbo.People", "Race_Id", "dbo.Races");
            DropForeignKey("dbo.Events", "Person_Id1", "dbo.People");
            DropForeignKey("dbo.People", "HomeCity_Id", "dbo.Cities");
            DropForeignKey("dbo.Events", "Person_Id", "dbo.People");
            DropForeignKey("dbo.Items", "Merchant_Id", "dbo.People");
            DropForeignKey("dbo.People", "Owner_Id", "dbo.People");
            DropForeignKey("dbo.Items", "Dominus_Id", "dbo.People");
            DropForeignKey("dbo.Houses", "Dominus_Id", "dbo.People");
            DropForeignKey("dbo.People", "Dominus_Id", "dbo.People");
            DropForeignKey("dbo.Items", "Gladiator_Id2", "dbo.People");
            DropForeignKey("dbo.PassiveTraits", "Race_Id", "dbo.Races");
            DropForeignKey("dbo.Items", "Gladiator_Id1", "dbo.People");
            DropForeignKey("dbo.Items", "Gladiator_Id", "dbo.People");
            DropForeignKey("dbo.Events", "AffectedHouse_Id", "dbo.Houses");
            DropForeignKey("dbo.Houses", "Location_Id", "dbo.Cities");
            DropForeignKey("dbo.Events", "AffectedCity_Id", "dbo.Cities");
            DropForeignKey("dbo.PassiveTraits", "Class_Id", "dbo.Classes");
            DropForeignKey("dbo.Arenas", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.PassiveTraits", "Affliction_Id", "dbo.Afflictions");
            DropForeignKey("dbo.Effects", "Ability_Id", "dbo.Abilities");
            DropIndex("dbo.Houses", new[] { "Dominus_Id" });
            DropIndex("dbo.Houses", new[] { "Location_Id" });
            DropIndex("dbo.Events", new[] { "Person_Id1" });
            DropIndex("dbo.Events", new[] { "Person_Id" });
            DropIndex("dbo.Events", new[] { "AffectedHouse_Id" });
            DropIndex("dbo.Events", new[] { "AffectedCity_Id" });
            DropIndex("dbo.People", new[] { "Party_Id" });
            DropIndex("dbo.People", new[] { "Race_Id" });
            DropIndex("dbo.People", new[] { "HomeCity_Id" });
            DropIndex("dbo.People", new[] { "Owner_Id" });
            DropIndex("dbo.People", new[] { "Dominus_Id" });
            DropIndex("dbo.Items", new[] { "Merchant_Id" });
            DropIndex("dbo.Items", new[] { "Dominus_Id" });
            DropIndex("dbo.Items", new[] { "Gladiator_Id2" });
            DropIndex("dbo.Items", new[] { "Gladiator_Id1" });
            DropIndex("dbo.Items", new[] { "Gladiator_Id" });
            DropIndex("dbo.Arenas", new[] { "City_Id" });
            DropIndex("dbo.PassiveTraits", new[] { "Race_Id" });
            DropIndex("dbo.PassiveTraits", new[] { "Class_Id" });
            DropIndex("dbo.PassiveTraits", new[] { "Affliction_Id" });
            DropIndex("dbo.Effects", new[] { "Ability_Id" });
            DropTable("dbo.Parties");
            DropTable("dbo.Races");
            DropTable("dbo.Houses");
            DropTable("dbo.Events");
            DropTable("dbo.People");
            DropTable("dbo.Deities");
            DropTable("dbo.Classes");
            DropTable("dbo.Cities");
            DropTable("dbo.Items");
            DropTable("dbo.Arenas");
            DropTable("dbo.PassiveTraits");
            DropTable("dbo.Afflictions");
            DropTable("dbo.Effects");
            DropTable("dbo.Abilities");
        }
    }
}
