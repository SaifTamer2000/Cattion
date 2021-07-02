namespace Cattion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class emerge : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "Membership_id", "dbo.Memberships");
            DropIndex("dbo.Customers", new[] { "Membership_id" });
            DropColumn("dbo.Customers", "MembershipId");
            RenameColumn(table: "dbo.Customers", name: "Membership_id", newName: "MembershipId");
            DropPrimaryKey("dbo.Memberships");
            AlterColumn("dbo.Customers", "MembershipId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Memberships", "id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Memberships", "SignUpFee", c => c.Short(nullable: false));
            AddPrimaryKey("dbo.Memberships", "id");
            CreateIndex("dbo.Customers", "MembershipId");
            AddForeignKey("dbo.Customers", "MembershipId", "dbo.Memberships", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipId", "dbo.Memberships");
            DropIndex("dbo.Customers", new[] { "MembershipId" });
            DropPrimaryKey("dbo.Memberships");
            AlterColumn("dbo.Memberships", "SignUpFee", c => c.Int());
            AlterColumn("dbo.Memberships", "id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Customers", "MembershipId", c => c.Int());
            AddPrimaryKey("dbo.Memberships", "id");
            RenameColumn(table: "dbo.Customers", name: "MembershipId", newName: "Membership_id");
            AddColumn("dbo.Customers", "MembershipId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "Membership_id");
            AddForeignKey("dbo.Customers", "Membership_id", "dbo.Memberships", "id");
        }
    }
}
