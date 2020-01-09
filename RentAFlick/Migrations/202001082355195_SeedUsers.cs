namespace RentAFlick.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6c8c87d1-dc05-4c5f-8155-3fde94cda102', N'guest@rentaflick.com', 0, N'AMLE7xjIlfdSw8Lo6MjpLtBB83h9IliXqTVanP0ZbUNWAwdbv8B+2xxT5r/3xV6r7A==', N'a45386a7-025b-412b-8135-bc44c79fc66b', NULL, 0, 0, NULL, 1, 0, N'guest@rentaflick.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e657928c-c4ff-408e-a5c1-c003fdd7d901', N'admin@rentaflick.com', 0, N'APSGCqo+vyTuueAj2mm/4ptsgzJjGjKnuALFWjQzkxlte9R+54thjjkD9KeuWhXXUw==', N'2cfcc6a9-7815-4499-bdc2-b0bf95436725', NULL, 0, 0, NULL, 1, 0, N'admin@rentaflick.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd72d2ead-0753-41a1-97be-e53961839b75', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e657928c-c4ff-408e-a5c1-c003fdd7d901', N'd72d2ead-0753-41a1-97be-e53961839b75')

");
        }
        
        public override void Down()
        {
        }
    }
}
