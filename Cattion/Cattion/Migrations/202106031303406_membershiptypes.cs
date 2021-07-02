namespace Cattion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class membershiptypes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Memberships",
                c => new
                    {
                        id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Customers", "MembershipId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "MembershipId");
            AddForeignKey("dbo.Customers", "MembershipId", "dbo.Memberships", "id", cascadeDelete: true);
            DropColumn("dbo.Customers", "isSupporter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "isSupporter", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Customers", "MembershipId", "dbo.Memberships");
            DropIndex("dbo.Customers", new[] { "MembershipId" });
            DropColumn("dbo.Customers", "MembershipId");
            DropTable("dbo.Memberships");
        }
    }
}
