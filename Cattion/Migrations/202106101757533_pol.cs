namespace Cattion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pol : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MembershipId", "dbo.Memberships");
            DropIndex("dbo.Customers", new[] { "MembershipId" });
            DropPrimaryKey("dbo.Memberships");
            AddColumn("dbo.Customers", "Membership_id", c => c.Int());
            AlterColumn("dbo.Memberships", "id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Memberships", "SignUpFee", c => c.Int());
            AddPrimaryKey("dbo.Memberships", "id");
            CreateIndex("dbo.Customers", "Membership_id");
            AddForeignKey("dbo.Customers", "Membership_id", "dbo.Memberships", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "Membership_id", "dbo.Memberships");
            DropIndex("dbo.Customers", new[] { "Membership_id" });
            DropPrimaryKey("dbo.Memberships");
            AlterColumn("dbo.Memberships", "SignUpFee", c => c.Short(nullable: false));
            AlterColumn("dbo.Memberships", "id", c => c.Byte(nullable: false));
            DropColumn("dbo.Customers", "Membership_id");
            AddPrimaryKey("dbo.Memberships", "id");
            CreateIndex("dbo.Customers", "MembershipId");
            AddForeignKey("dbo.Customers", "MembershipId", "dbo.Memberships", "id", cascadeDelete: true);
        }
    }
}
