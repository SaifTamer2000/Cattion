namespace Cattion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedcustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CatsId", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "Cats_id", c => c.Int());
            CreateIndex("dbo.Customers", "Cats_id");
            AddForeignKey("dbo.Customers", "Cats_id", "dbo.Cats", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "Cats_id", "dbo.Cats");
            DropIndex("dbo.Customers", new[] { "Cats_id" });
            DropColumn("dbo.Customers", "Cats_id");
            DropColumn("dbo.Customers", "CatsId");
        }
    }
}
