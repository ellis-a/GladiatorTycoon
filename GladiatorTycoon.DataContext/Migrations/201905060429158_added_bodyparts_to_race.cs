namespace GladiatorTycoon.DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_bodyparts_to_race : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BodyParts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        DevName = c.String(unicode: false),
                        AvailableActions = c.Int(nullable: false),
                        RequiredForLiving = c.Boolean(nullable: false),
                        BodyPartType = c.Int(nullable: false),
                        RaceEntity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Races", t => t.RaceEntity_Id)
                .Index(t => t.RaceEntity_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BodyParts", "RaceEntity_Id", "dbo.Races");
            DropIndex("dbo.BodyParts", new[] { "RaceEntity_Id" });
            DropTable("dbo.BodyParts");
        }
    }
}
