namespace Cattion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class supportertype : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "isSupporter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "isSupporter");
        }
    }
}
