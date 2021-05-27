namespace DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedspeedandbravery : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persons", "BasePower", c => c.Int(nullable: false));
            AddColumn("dbo.Persons", "BaseWits", c => c.Int(nullable: false));
            AddColumn("dbo.Persons", "BaseSkill", c => c.Int(nullable: false));
            AddColumn("dbo.Persons", "BaseCharisma", c => c.Int(nullable: false));
            AddColumn("dbo.Persons", "BaseBravery", c => c.Int(nullable: false));
            AddColumn("dbo.Persons", "Speed", c => c.Int(nullable: false));
            DropColumn("dbo.Persons", "Power");
            DropColumn("dbo.Persons", "Wits");
            DropColumn("dbo.Persons", "Skill");
            DropColumn("dbo.Persons", "Charisma");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Persons", "Charisma", c => c.Int(nullable: false));
            AddColumn("dbo.Persons", "Skill", c => c.Int(nullable: false));
            AddColumn("dbo.Persons", "Wits", c => c.Int(nullable: false));
            AddColumn("dbo.Persons", "Power", c => c.Int(nullable: false));
            DropColumn("dbo.Persons", "Speed");
            DropColumn("dbo.Persons", "BaseBravery");
            DropColumn("dbo.Persons", "BaseCharisma");
            DropColumn("dbo.Persons", "BaseSkill");
            DropColumn("dbo.Persons", "BaseWits");
            DropColumn("dbo.Persons", "BasePower");
        }
    }
}
