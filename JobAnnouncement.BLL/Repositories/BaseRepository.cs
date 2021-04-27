using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using JobAnnouncement.BLL.DTOs;

namespace JobAnnouncement.BLL.Repositories
{
    public class BaseRepository<TDto, TContext> : IBaseRepository<TDto>
     where TDto : BaseDTO
     where TContext : DbContext
    {
        private TContext _tdbcontext;

        public BaseRepository(TContext tdbcontext)
        {
            _tdbcontext = tdbcontext;
        }
        public TDto GetAll()
        {
            return null;
        }

        public TDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id, int userId = 0)
        {
            throw new NotImplementedException();
        }

        public void Save(TDto obj, int userId = 0)
        {
            throw new NotImplementedException();
        }
    }
}