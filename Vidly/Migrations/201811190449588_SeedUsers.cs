namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'34652ec4-222e-49db-a989-11a6a63c739c', N'admin@email.com', 0, N'AJ8imxP0OvGZVx0tqh3TCQs5Zuze9JpI4sXg/3UjW0lFbjlw3tLUMLAX29janTrVwg==', N'6e81a549-1af4-4b7e-ba45-921ebcd84a8b', NULL, 0, 0, NULL, 1, 0, N'admin@email.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'442fe84a-fe83-4db7-9396-d26f9386dc11', N'guest@email.com', 0, N'AGndNPVglWqSCq4mgLA5pUabDG+BzayOGJ1KXyo12QHrelG2lUKrNoAQabG4McqFvg==', N'e1e631f0-27ea-4ed8-ab13-b7dfc1fa0345', NULL, 0, 0, NULL, 1, 0, N'guest@email.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'474b7475-8708-439f-a96b-209d8fe8c996', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'34652ec4-222e-49db-a989-11a6a63c739c', N'474b7475-8708-439f-a96b-209d8fe8c996')


");
        }
        
        public override void Down()
        {
        }
    }
}
