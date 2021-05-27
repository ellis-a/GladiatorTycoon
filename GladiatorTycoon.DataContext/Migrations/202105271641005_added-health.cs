namespace DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedhealth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persons", "MaxHealth", c => c.Int(nullable: false));
            AddColumn("dbo.Persons", "CurrentHealth", c => c.Int(nullable: false));
            DropColumn("dbo.Persons", "Offense");
            DropColumn("dbo.Persons", "Defense");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Persons", "Defense", c => c.Int(nullable: false));
            AddColumn("dbo.Persons", "Offense", c => c.Int(nullable: false));
            DropColumn("dbo.Persons", "CurrentHealth");
            DropColumn("dbo.Persons", "MaxHealth");
        }
    }
}
