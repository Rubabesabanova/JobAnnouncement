using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AutoMapper;
using JobAnnouncement.BLL.DTOs;
using JobAnnouncement.DAL.DAOs;
using JobAnnouncement.DAL.JobDbContext;
using JobAnnouncement.DAL.Repositories;

namespace JobAnnouncement.BLL.Repositories
{
    public class BaseRepository<TDao, TDto, TContext> : IBaseRepository<TDto, TDao>
     where TDao: BaseDAO
     where TDto : BaseDTO
     where TContext : DbContext
    {
        private TContext _tdbcontext;
        private BaseRepository<TDao, TContext> _baserepository;
        private JobAnnouncementDbContext dbContext;

        public BaseRepository(JobAnnouncementDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public BaseRepository(TContext tdbcontext, BaseRepository<TDao, TContext> baseRepository)
        {
            _baserepository = baseRepository;
            _tdbcontext = tdbcontext;
        }
        public ICollection<TDto> GetAll()
        {
            return Mapper.Map<ICollection<TDto>>(_baserepository.GetAll());
        }

        public TDto GetById(int id)
        {
            return Mapper.Map<TDto>(_baserepository.GetById(id));
        }

        public void Remove(int id, int userId = 0)
        {
            _baserepository.Remove(id, userId);
        }

        public void Save(TDto obj, int userId = 0)
        {
            TDao dao = Mapper.Map<TDao>(obj);
            _baserepository.Save(dao, userId);
        }
    }
}