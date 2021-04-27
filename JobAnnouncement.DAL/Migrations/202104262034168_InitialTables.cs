namespace JobAnnouncement.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Icon = c.String(maxLength: 20),
                        CreatedUserId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        VacancyCount = c.Int(nullable: false),
                        Salary = c.Double(nullable: false),
                        Location = c.String(),
                        JobNature = c.Int(nullable: false),
                        Description = c.String(),
                        UserId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        CreatedUserId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Role = c.Int(nullable: false),
                        CreatedUserId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CategorySlider",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        CreatedUserId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Location = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        CreatedUserId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.JobSliders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Count = c.String(nullable: false),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        CreatedUserId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsVisible = c.Boolean(nullable: false),
                        OrderBy = c.Int(nullable: false),
                        CreatedUserId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SocialMedias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Facebook = c.String(),
                        Instagram = c.String(),
                        Behance = c.String(),
                        Youtube = c.String(),
                        Twitter = c.String(),
                        CreatedUserId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Testimonials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        Author = c.String(nullable: false),
                        Speciality = c.String(nullable: false),
                        CreatedUserId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jobs", "UserId", "dbo.Users");
            DropForeignKey("dbo.Jobs", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Jobs", new[] { "CategoryId" });
            DropIndex("dbo.Jobs", new[] { "UserId" });
            DropTable("dbo.Testimonials");
            DropTable("dbo.SocialMedias");
            DropTable("dbo.Menus");
            DropTable("dbo.JobSliders");
            DropTable("dbo.Features");
            DropTable("dbo.CategorySlider");
            DropTable("dbo.Users");
            DropTable("dbo.Jobs");
            DropTable("dbo.Categories");
        }
    }
}
