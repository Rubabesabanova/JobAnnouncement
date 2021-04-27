using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobAnnouncement.BLL.DTOs;
using JobAnnouncement.DAL.DAOs;

namespace JobAnnouncement.BLL.Repositories
{
    public interface IBaseRepository<TDto, TDao> where TDto : BaseDTO
        where TDao: BaseDAO
    {
        ICollection<TDto> GetAll();
        TDto GetById(int id);
        void Remove(int id, int userId = 0);
        void Save(TDto obj, int userId = 0);
    }
}
