using AutoMapper;
using AutoMapper.QueryableExtensions;
using JobAnnouncement.BLL.DTOs;
using JobAnnouncement.BLL.Repositories;
using JobAnnouncement.DAL.DAOs;
using System;
using System.Data.Entity;
using System.Linq;

namespace JobAnnouncement.DAL.Repositories
{
    public abstract class BaseRepository<TDto, TDao, TContext> : IBaseRepository<TDto>
     where TDto : BaseDTO
     where TDao : BaseDAO
     where TContext : DbContext
    {
        private TContext _tdbcontext;

        public BaseRepository(TContext tdbcontext)
        {
            _tdbcontext = tdbcontext;
        }

        public TDto GetAll()
        {
            try
            {
                return Mapper.Map<TDto>(_tdbcontext.Set<TDao>());
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public TDto GetById(int id)
        {
            try
            {
                var dto = Mapper.Map<TDto>(_tdbcontext.Set<TDao>().FirstOrDefault(e => e.Id == id));
                return dto;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void Remove(int id, int userId = 0)
        {
            try
            {
                var dao = _tdbcontext.Set<TDao>().FirstOrDefault(e => e.Id == id);
                _tdbcontext.Entry(dao).State = EntityState.Deleted;
                
                
            }
            catch (Exception ex)
            {
                
            }
        }

        public void Save(TDto obj, int userId = 0)
        {
            throw new NotImplementedException();
        }

        private void Add(TDto obj, int userId = 0)
        {
            try
            {
                var model = Mapper.Map<TDao>(obj);
                model.CreatedUserId = userId;
                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = null;
                using (var transaction = _tdbcontext.Database.BeginTransaction())
                {
                    if (obj.Id == 0)
                    {
                        _tdbcontext.Set<TDao>().Add(model);
                        var result = _tdbcontext.SaveChanges();
                    }
                    obj.Id = model.Id;
                    
                }

            }
            catch (Exception ex)
            {
                
            }
        }

        private void Update(TDto obj, int userId = 0)
        {
            try
            {
                var model = Mapper.Map<TDao>(obj);
                using (var transaction = _tdbcontext.Database.BeginTransaction())
                {
                    var dbModel = _tdbcontext.Set<TDao>().FirstOrDefault(x => x.Id == model.Id);
                    dbModel.ModifiedDate = DateTime.Now;
                    var entry = _tdbcontext.Entry(dbModel);
                    entry.CurrentValues.SetValues(model);
                    entry.Property(x => x.CreatedDate).IsModified = false;
                    entry.Property(x => x.CreatedUserId).IsModified = false;
                    _tdbcontext.SaveChanges();
                    transaction.Commit();
                    obj.Id = model.Id;
                    
                }

            }
            catch (Exception ex)
            {
             
            }
            
        }

        
    }
}