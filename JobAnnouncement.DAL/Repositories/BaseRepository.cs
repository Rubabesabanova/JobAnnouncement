using AutoMapper;
using AutoMapper.QueryableExtensions;
using JobAnnouncement.BLL.DTOs;
using JobAnnouncement.DAL.DAOs;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace JobAnnouncement.DAL.Repositories
{
    public abstract class BaseRepository< TDao, TContext> : IBaseRepository<TDao>
     where TDao : BaseDAO
     where TContext : DbContext
    {
        private TContext _tdbcontext;

        public BaseRepository(TContext tdbcontext)
        {
            _tdbcontext = tdbcontext;
        }

        public ICollection<TDao> GetAll()
        {
            try
            {
                return (ICollection<TDao>)_tdbcontext.Set<TDao>();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public TDao GetById(int id)
        {
            try
            {
                var dao = _tdbcontext.Set<TDao>().FirstOrDefault(e => e.Id == id);
                return dao;
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

        public void Save(TDao obj, int userId = 0)
        {
            throw new NotImplementedException();
        }

        private void Add(TDao obj, int userId = 0)
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

        private void Update(TDao obj, int userId = 0)
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