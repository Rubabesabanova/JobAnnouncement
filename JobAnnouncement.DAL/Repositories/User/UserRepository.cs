using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JobAnnouncement.BLL.DTOs.User;
using JobAnnouncement.DAL.DAOs.User;
using JobAnnouncement.DAL.JobDbContext;
using JobAnnouncement.DAL.Repositories;

namespace JobAnnouncement.DAL.Repositories.User
{
    public class UserRepository : BaseRepository<UserDAO, JobAnnouncementDbContext>, IUserRepository
    {
        public UserRepository(JobAnnouncementDbContext dbContext) : base(dbContext)
        {

        }
    }
}