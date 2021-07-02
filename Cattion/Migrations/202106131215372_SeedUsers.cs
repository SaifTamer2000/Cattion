namespace Cattion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
             INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'4a278bdb-974f-43a8-a980-6c9fddb3b5d0', N'saif@domain.com', 0, N'AE1lQL5fpl0lwd+dksTHrY+HNy3Xbyo0to/oJd1XVHT4df8N1r958XiRq47xdDfjXQ==', N'ec40aade-deb8-4292-a5ca-eb5ace02e263', NULL, 0, 0, NULL, 1, 0, N'saif@domain.com')
INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'54cf21c1-18d8-426e-aa38-c6aef029cb3f', N'magda.ehab@gmail.com', 0, N'AHbar+It9Rvoe2MOb616XFOWop4FWS85APdtxY4KxyZPXLWX1IL6vmIjJVaAVCjYog==', N'f1738faf-040a-44bf-858d-8a0d5bc5e0b5', NULL, 0, 0, NULL, 1, 0, N'magda.ehab@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b0c0afcc-082a-4283-a769-a37e98ef1300', N'CanAddNewCustomer')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'54cf21c1-18d8-426e-aa38-c6aef029cb3f', N'b0c0afcc-082a-4283-a769-a37e98ef1300')
 ");
        }
        
        public override void Down()
        {
        }
    }
}
