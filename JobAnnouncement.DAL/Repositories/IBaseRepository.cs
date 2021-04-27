using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobAnnouncement.BLL.DTOs;

namespace JobAnnouncement.DAL.Repositories
{
    public interface IBaseRepository<TDto> where TDto : BaseDTO
    {
        TDto GetAll();
        TDto GetById(int id);
        void Remove(int id, int userId = 0);
        void Save(TDto obj, int userId = 0);
    }
}
