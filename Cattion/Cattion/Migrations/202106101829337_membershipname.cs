namespace Cattion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class membershipname : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Memberships", "name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Memberships", "name", c => c.String());
        }
    }
}
