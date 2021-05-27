namespace DataContext.Migrations
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
                        Name = c.String(unicode: false),
                        Description = c.String(unicode: false),
                        ActionType = c.Int(nullable: false),
                        ReactionTrigger = c.Int(nullable: false),
                        MagicTypes = c.Int(nullable: false),
                        Duration = c.Int(nullable: false),
                        PowerMod = c.Int(nullable: false),
                        SkillMod = c.Int(nullable: false),
                        CombatClassEntity_Id = c.Int(),
                        RaceEntity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CombatClasses", t => t.CombatClassEntity_Id)
                .ForeignKey("dbo.Races", t => t.RaceEntity_Id)
                .Index(t => t.CombatClassEntity_Id)
                .Index(t => t.RaceEntity_Id);
            
            CreateTable(
                "dbo.Passives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AbilityEntity_Id = c.Int(),
                        AfflictionEntity_Id = c.Int(),
                        CombatClassEntity_Id = c.Int(),
                        RaceEntity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Abilities", t => t.AbilityEntity_Id)
                .ForeignKey("dbo.Afflictions", t => t.AfflictionEntity_Id)
                .ForeignKey("dbo.CombatClasses", t => t.CombatClassEntity_Id)
                .ForeignKey("dbo.Races", t => t.RaceEntity_Id)
                .Index(t => t.AbilityEntity_Id)
                .Index(t => t.AfflictionEntity_Id)
                .Index(t => t.CombatClassEntity_Id)
                .Index(t => t.RaceEntity_Id);
            
            CreateTable(
                "dbo.Afflictions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cure = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
                        MerchantEntity_Id = c.Int(),
                        PersonEntity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Masters", t => t.MasterEntity_Id)
                .ForeignKey("dbo.Merchants", t => t.MerchantEntity_Id)
                .ForeignKey("dbo.Persons", t => t.PersonEntity_Id)
                .Index(t => t.MasterEntity_Id)
                .Index(t => t.MerchantEntity_Id)
                .Index(t => t.PersonEntity_Id);
            
            CreateTable(
                "dbo.CombatClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        RaceEntity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Races", t => t.RaceEntity_Id)
                .Index(t => t.RaceEntity_Id);
            
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
                        Gender = c.Int(nullable: false),
                        Power = c.Int(nullable: false),
                        Wits = c.Int(nullable: false),
                        Skill = c.Int(nullable: false),
                        Charisma = c.Int(nullable: false),
                        Offense = c.Int(nullable: false),
                        Defense = c.Int(nullable: false),
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
                        AvailableGenders = c.Int(nullable: false),
                        PositiveHabitats = c.String(unicode: false),
                        NegativeHabitats = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PersonNames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(unicode: false),
                        IsFirstName = c.Boolean(nullable: false),
                        Gender = c.Int(nullable: false),
                        RaceEntity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Races", t => t.RaceEntity_Id)
                .Index(t => t.RaceEntity_Id);
            
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
                        Defense = c.Int(nullable: false),
                        ArmourSlot = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.Id)
                .Index(t => t.Id);
            
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
                "dbo.Merchants",
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
                "dbo.Weapons",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Offense = c.Int(nullable: false),
                        WeaponType = c.Int(nullable: false),
                        IsTwoHander = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Weapons", "Id", "dbo.Items");
            DropForeignKey("dbo.Slaves", "Owner_Id", "dbo.Masters");
            DropForeignKey("dbo.Slaves", "Id", "dbo.Persons");
            DropForeignKey("dbo.Merchants", "Id", "dbo.Persons");
            DropForeignKey("dbo.Masters", "Id", "dbo.Persons");
            DropForeignKey("dbo.Armours", "Id", "dbo.Items");
            DropForeignKey("dbo.Persons", "PartyEntity_Id", "dbo.Parties");
            DropForeignKey("dbo.Persons", "Race_Id", "dbo.Races");
            DropForeignKey("dbo.Persons", "HomeCity_Id", "dbo.Cities");
            DropForeignKey("dbo.Items", "PersonEntity_Id", "dbo.Persons");
            DropForeignKey("dbo.Items", "MerchantEntity_Id", "dbo.Merchants");
            DropForeignKey("dbo.Passives", "RaceEntity_Id", "dbo.Races");
            DropForeignKey("dbo.CombatClasses", "RaceEntity_Id", "dbo.Races");
            DropForeignKey("dbo.PersonNames", "RaceEntity_Id", "dbo.Races");
            DropForeignKey("dbo.Abilities", "RaceEntity_Id", "dbo.Races");
            DropForeignKey("dbo.Items", "MasterEntity_Id", "dbo.Masters");
            DropForeignKey("dbo.Houses", "MasterEntity_Id", "dbo.Masters");
            DropForeignKey("dbo.Houses", "Location_Id", "dbo.Cities");
            DropForeignKey("dbo.Passives", "CombatClassEntity_Id", "dbo.CombatClasses");
            DropForeignKey("dbo.Abilities", "CombatClassEntity_Id", "dbo.CombatClasses");
            DropForeignKey("dbo.Arenas", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Passives", "AfflictionEntity_Id", "dbo.Afflictions");
            DropForeignKey("dbo.Passives", "AbilityEntity_Id", "dbo.Abilities");
            DropIndex("dbo.Weapons", new[] { "Id" });
            DropIndex("dbo.Slaves", new[] { "Owner_Id" });
            DropIndex("dbo.Slaves", new[] { "Id" });
            DropIndex("dbo.Merchants", new[] { "Id" });
            DropIndex("dbo.Masters", new[] { "Id" });
            DropIndex("dbo.Armours", new[] { "Id" });
            DropIndex("dbo.PersonNames", new[] { "RaceEntity_Id" });
            DropIndex("dbo.Houses", new[] { "MasterEntity_Id" });
            DropIndex("dbo.Houses", new[] { "Location_Id" });
            DropIndex("dbo.Persons", new[] { "PartyEntity_Id" });
            DropIndex("dbo.Persons", new[] { "Race_Id" });
            DropIndex("dbo.Persons", new[] { "HomeCity_Id" });
            DropIndex("dbo.CombatClasses", new[] { "RaceEntity_Id" });
            DropIndex("dbo.Items", new[] { "PersonEntity_Id" });
            DropIndex("dbo.Items", new[] { "MerchantEntity_Id" });
            DropIndex("dbo.Items", new[] { "MasterEntity_Id" });
            DropIndex("dbo.Arenas", new[] { "City_Id" });
            DropIndex("dbo.Passives", new[] { "RaceEntity_Id" });
            DropIndex("dbo.Passives", new[] { "CombatClassEntity_Id" });
            DropIndex("dbo.Passives", new[] { "AfflictionEntity_Id" });
            DropIndex("dbo.Passives", new[] { "AbilityEntity_Id" });
            DropIndex("dbo.Abilities", new[] { "RaceEntity_Id" });
            DropIndex("dbo.Abilities", new[] { "CombatClassEntity_Id" });
            DropTable("dbo.Weapons");
            DropTable("dbo.Slaves");
            DropTable("dbo.Merchants");
            DropTable("dbo.Masters");
            DropTable("dbo.Armours");
            DropTable("dbo.Parties");
            DropTable("dbo.PersonNames");
            DropTable("dbo.Races");
            DropTable("dbo.Houses");
            DropTable("dbo.Persons");
            DropTable("dbo.Deities");
            DropTable("dbo.CombatClasses");
            DropTable("dbo.Items");
            DropTable("dbo.Cities");
            DropTable("dbo.Arenas");
            DropTable("dbo.Afflictions");
            DropTable("dbo.Passives");
            DropTable("dbo.Abilities");
        }
    }
}
