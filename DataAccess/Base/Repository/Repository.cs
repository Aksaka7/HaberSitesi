using DataAccess.Absract.Repository;
using DataAccess.Context;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Base.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly HaberContext context;

        public Repository(HaberContext context)
        {
            this.context = context;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>();
        }

        public TEntity GetByID(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public TEntity Insert(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
            return entity;
        }

        public bool Delete(TEntity entity)
        {
            try
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
