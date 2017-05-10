namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'42f9859f-b1bb-48cc-8b7f-1ce191627e84', N'guest@vidly.com', 0, N'AFzXVDWXmFqsTgV3XjGR5HcColO81HVubYpRGWCNVOusM18SkP6n5O2Ff0BK1lX3sw==', N'0cc5ba23-54c9-41d6-9baa-6a74bc35f951', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'48d1ad86-fc7c-421c-ac45-5659b9243d30', N'admin@vidly.com', 0, N'AFjH/UsmkMSwx7dKlKEcUdwzMoot+r4eBp/QE63IBSQSTddsfqGRYv/rznxpI//t4Q==', N'b2f1d0e5-0ca5-48b5-a7d4-4deb981ed477', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'811bc0a7-5b45-4e0a-b62b-c18e2d8fed58', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'48d1ad86-fc7c-421c-ac45-5659b9243d30', N'811bc0a7-5b45-4e0a-b62b-c18e2d8fed58')
");
        }
        
        public override void Down()
        {
        }
    }
}
