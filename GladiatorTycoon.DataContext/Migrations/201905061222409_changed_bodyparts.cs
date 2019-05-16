namespace GladiatorTycoon.DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changed_bodyparts : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.BodyParts", newName: "RaceBodyParts");
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonBodyParts", "RaceBodyPart_Id", "dbo.RaceBodyParts");
            DropForeignKey("dbo.Injuries", "PersonBodyPartEntity_Id", "dbo.PersonBodyParts");
            DropForeignKey("dbo.PersonBodyParts", "EquippedWeapon_Id", "dbo.Weapons");
            DropForeignKey("dbo.PersonBodyParts", "EquippedArmour_Id", "dbo.Armours");
            DropIndex("dbo.PersonBodyParts", new[] { "RaceBodyPart_Id" });
            DropIndex("dbo.PersonBodyParts", new[] { "EquippedWeapon_Id" });
            DropIndex("dbo.PersonBodyParts", new[] { "EquippedArmour_Id" });
            DropIndex("dbo.Injuries", new[] { "PersonBodyPartEntity_Id" });
            DropTable("dbo.PersonBodyParts");
            DropTable("dbo.Injuries");
            RenameTable(name: "dbo.RaceBodyParts", newName: "BodyParts");
        }
    }
}
