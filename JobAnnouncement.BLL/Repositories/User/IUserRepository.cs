using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobAnnouncement.BLL.DTOs.User;
using JobAnnouncement.DAL.DAOs.User;

namespace JobAnnouncement.BLL.Repositories.User
{
    public interface IUserRepository : IBaseRepository<UserDTO, UserDAO, JobAnnouncement.DAL.Repositories.User.IUserRepository>
    {
    }
}
