namespace JobAnnouncement.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using JobAnnouncement.DAL.DAOs.User;

    internal sealed class Configuration : DbMigrationsConfiguration<JobAnnouncement.DAL.JobDbContext.JobAnnouncementDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(JobAnnouncement.DAL.JobDbContext.JobAnnouncementDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Users.AddOrUpdate(
                 p => p.Email,
                  new UserDAO { Username = "Ali", Role = 1, Email = "ali@gmail.com", Password = "123", CreatedDate = DateTime.Now,  },
                 new UserDAO { Username = "Bali", Role = 1, Email = "bali@gmail.com", Password = "123", CreatedDate = DateTime.Now, }
                ) ;
        }
    }
}
