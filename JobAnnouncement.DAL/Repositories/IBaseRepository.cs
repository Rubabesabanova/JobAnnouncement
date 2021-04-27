using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobAnnouncement.BLL.DTOs;
using JobAnnouncement.DAL.DAOs;

namespace JobAnnouncement.DAL.Repositories
{
    public interface IBaseRepository<TDao> 
        where TDao : BaseDAO
    {
        ICollection<TDao> GetAll();
        TDao GetById(int id);
        void Remove(int id, int userId = 0);
        void Save(TDao obj, int userId = 0);
    }
}
