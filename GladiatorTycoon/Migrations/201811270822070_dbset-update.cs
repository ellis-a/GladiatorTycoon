namespace GladiatorTycoon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbsetupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Races", "PositiveHabitats", c => c.String(unicode: false));
            AddColumn("dbo.Races", "NegativeHabitats", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Races", "NegativeHabitats");
            DropColumn("dbo.Races", "PositiveHabitats");
        }
    }
}
