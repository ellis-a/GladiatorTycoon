namespace GladiatorTycoon.DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
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
                        CombatClassEntity_Id = c.Int(),
                        RaceEntity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Afflictions", t => t.AfflictionEntity_Id)
                .ForeignKey("dbo.CombatClasses", t => t.CombatClassEntity_Id)
                .ForeignKey("dbo.Races", t => t.RaceEntity_Id)
                .Index(t => t.AfflictionEntity_Id)
                .Index(t => t.CombatClassEntity_Id)
                .Index(t => t.RaceEntity_Id);
            
            CreateTable(
                "dbo.Arenas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        City_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .Index(t => t.City_Id);
            
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
                .ForeignKey("dbo.Merchants", t => t.MerchantEntity_Id)
                .Index(t => t.MasterEntity_Id)
                .Index(t => t.GladiatorEntity_Id1)
                .Index(t => t.MerchantEntity_Id);
            
            CreateTable(
                "dbo.CombatClasses",
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
                        Skill = c.Int(nullable: false),
                        Charisma = c.Int(nullable: false),
                        HomeCity_Id = c.Int(),
                        Race_Id = c.Int(),
                        PartyEntity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.HomeCity_Id)
                .ForeignKey("dbo.Races", t => t.Race_Id)
                .ForeignKey("dbo.Parties", t => t.PartyEntity_Id)
                .Index(t => t.HomeCity_Id)
                .Index(t => t.Race_Id)
                .Index(t => t.PartyEntity_Id);
            
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
                .ForeignKey("dbo.Masters", t => t.MasterEntity_Id)
                .Index(t => t.Location_Id)
                .Index(t => t.MasterEntity_Id);
            
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
                "dbo.RaceBodyParts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        DevName = c.String(unicode: false),
                        BodyPartType = c.Int(nullable: false),
                        AvailableActions = c.Int(nullable: false),
                        RequiredForLiving = c.Boolean(nullable: false),
                        RaceEntity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Races", t => t.RaceEntity_Id)
                .Index(t => t.RaceEntity_Id);
            
            CreateTable(
                "dbo.Injuries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonBodyPartEntity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PersonBodyParts", t => t.PersonBodyPartEntity_Id)
                .Index(t => t.PersonBodyPartEntity_Id);
            
            CreateTable(
                "dbo.Parties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SuccessScore = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PersonBodyParts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EquippedArmour_Id = c.Int(),
                        EquippedWeapon_Id = c.Int(),
                        RaceBodyPart_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Armours", t => t.EquippedArmour_Id)
                .ForeignKey("dbo.Weapons", t => t.EquippedWeapon_Id)
                .ForeignKey("dbo.RaceBodyParts", t => t.RaceBodyPart_Id)
                .Index(t => t.EquippedArmour_Id)
                .Index(t => t.EquippedWeapon_Id)
                .Index(t => t.RaceBodyPart_Id);
            
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
                .ForeignKey("dbo.Gladiators", t => t.GladiatorEntity_Id)
                .Index(t => t.Id)
                .Index(t => t.GladiatorEntity_Id);
            
            CreateTable(
                "dbo.Masters",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Persons", t => t.Id)
                .Index(t => t.Id);
            
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
                .ForeignKey("dbo.Masters", t => t.Owner_Id)
                .Index(t => t.Id)
                .Index(t => t.Owner_Id);
            
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
                .ForeignKey("dbo.Slaves", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Merchants",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Persons", t => t.Id)
                .Index(t => t.Id);
            
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
                .ForeignKey("dbo.Gladiators", t => t.GladiatorEntity_Id)
                .Index(t => t.Id)
                .Index(t => t.GladiatorEntity_Id);
            
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
            DropForeignKey("dbo.PersonBodyParts", "RaceBodyPart_Id", "dbo.RaceBodyParts");
            DropForeignKey("dbo.Injuries", "PersonBodyPartEntity_Id", "dbo.PersonBodyParts");
            DropForeignKey("dbo.PersonBodyParts", "EquippedWeapon_Id", "dbo.Weapons");
            DropForeignKey("dbo.PersonBodyParts", "EquippedArmour_Id", "dbo.Armours");
            DropForeignKey("dbo.Persons", "PartyEntity_Id", "dbo.Parties");
            DropForeignKey("dbo.Persons", "Race_Id", "dbo.Races");
            DropForeignKey("dbo.Persons", "HomeCity_Id", "dbo.Cities");
            DropForeignKey("dbo.Items", "MerchantEntity_Id", "dbo.Merchants");
            DropForeignKey("dbo.Items", "GladiatorEntity_Id1", "dbo.Gladiators");
            DropForeignKey("dbo.Passives", "RaceEntity_Id", "dbo.Races");
            DropForeignKey("dbo.RaceBodyParts", "RaceEntity_Id", "dbo.Races");
            DropForeignKey("dbo.Items", "MasterEntity_Id", "dbo.Masters");
            DropForeignKey("dbo.Houses", "MasterEntity_Id", "dbo.Masters");
            DropForeignKey("dbo.Houses", "Location_Id", "dbo.Cities");
            DropForeignKey("dbo.Passives", "CombatClassEntity_Id", "dbo.CombatClasses");
            DropForeignKey("dbo.Arenas", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Passives", "AfflictionEntity_Id", "dbo.Afflictions");
            DropIndex("dbo.Weapons", new[] { "GladiatorEntity_Id" });
            DropIndex("dbo.Weapons", new[] { "Id" });
            DropIndex("dbo.Merchants", new[] { "Id" });
            DropIndex("dbo.Gladiators", new[] { "Id" });
            DropIndex("dbo.Slaves", new[] { "Owner_Id" });
            DropIndex("dbo.Slaves", new[] { "Id" });
            DropIndex("dbo.Masters", new[] { "Id" });
            DropIndex("dbo.Armours", new[] { "GladiatorEntity_Id" });
            DropIndex("dbo.Armours", new[] { "Id" });
            DropIndex("dbo.PersonBodyParts", new[] { "RaceBodyPart_Id" });
            DropIndex("dbo.PersonBodyParts", new[] { "EquippedWeapon_Id" });
            DropIndex("dbo.PersonBodyParts", new[] { "EquippedArmour_Id" });
            DropIndex("dbo.Injuries", new[] { "PersonBodyPartEntity_Id" });
            DropIndex("dbo.RaceBodyParts", new[] { "RaceEntity_Id" });
            DropIndex("dbo.Houses", new[] { "MasterEntity_Id" });
            DropIndex("dbo.Houses", new[] { "Location_Id" });
            DropIndex("dbo.Persons", new[] { "PartyEntity_Id" });
            DropIndex("dbo.Persons", new[] { "Race_Id" });
            DropIndex("dbo.Persons", new[] { "HomeCity_Id" });
            DropIndex("dbo.Items", new[] { "MerchantEntity_Id" });
            DropIndex("dbo.Items", new[] { "GladiatorEntity_Id1" });
            DropIndex("dbo.Items", new[] { "MasterEntity_Id" });
            DropIndex("dbo.Arenas", new[] { "City_Id" });
            DropIndex("dbo.Passives", new[] { "RaceEntity_Id" });
            DropIndex("dbo.Passives", new[] { "CombatClassEntity_Id" });
            DropIndex("dbo.Passives", new[] { "AfflictionEntity_Id" });
            DropTable("dbo.Weapons");
            DropTable("dbo.Merchants");
            DropTable("dbo.Gladiators");
            DropTable("dbo.Slaves");
            DropTable("dbo.Masters");
            DropTable("dbo.Armours");
            DropTable("dbo.PersonBodyParts");
            DropTable("dbo.Parties");
            DropTable("dbo.Injuries");
            DropTable("dbo.RaceBodyParts");
            DropTable("dbo.Races");
            DropTable("dbo.Houses");
            DropTable("dbo.Persons");
            DropTable("dbo.Deities");
            DropTable("dbo.CombatClasses");
            DropTable("dbo.Items");
            DropTable("dbo.Cities");
            DropTable("dbo.Arenas");
            DropTable("dbo.Passives");
            DropTable("dbo.Afflictions");
            DropTable("dbo.Abilities");
        }
    }
}
