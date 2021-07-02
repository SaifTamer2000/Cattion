namespace Cattion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class catpic : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cats", "imagepath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cats", "imagepath");
        }
    }
}
