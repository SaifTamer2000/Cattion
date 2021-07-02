namespace Cattion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class namemembership : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Memberships", "name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Memberships", "name");
        }
    }
}
