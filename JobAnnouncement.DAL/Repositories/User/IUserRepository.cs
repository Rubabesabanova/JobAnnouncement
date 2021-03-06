using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobAnnouncement.BLL.DTOs.User;
using JobAnnouncement.DAL.DAOs.User;

namespace JobAnnouncement.DAL.Repositories.User
{
    public interface IUserRepository : IBaseRepository<UserDAO>
    {
    }
}
