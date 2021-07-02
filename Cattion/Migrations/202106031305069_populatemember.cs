namespace Cattion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatemember : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Memberships (id,SignUpFee,DurationInMonths,DiscountRate) VALUES (1,0,0,0)");
            Sql("INSERT INTO Memberships (id,SignUpFee,DurationInMonths,DiscountRate) VALUES (2,20,3,10)");
            Sql("INSERT INTO Memberships (id,SignUpFee,DurationInMonths,DiscountRate) VALUES (3,50,9,20)");
            Sql("INSERT INTO Memberships (id,SignUpFee,DurationInMonths,DiscountRate) VALUES (4,100,24,50)");
        }
        
        public override void Down()
        {
        }
    }
}
