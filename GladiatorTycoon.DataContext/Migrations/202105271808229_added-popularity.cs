namespace DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedpopularity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persons", "Popularity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Persons", "Popularity");
        }
    }
}
