namespace GladiatorTycoon.DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renamed_speed_to_skill : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persons", "Skill", c => c.Int(nullable: false));
            DropColumn("dbo.Persons", "Speed");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Persons", "Speed", c => c.Int(nullable: false));
            DropColumn("dbo.Persons", "Skill");
        }
    }
}
