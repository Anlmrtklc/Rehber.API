using Microsoft.EntityFrameworkCore;
using Rehber.API.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rehber.API.Data.Concrate
{
    public class Repository<TEntity, TContex> : IRepository<TEntity> 
        where TEntity : class, new()
        where TContex : DbContext, new()
    {
        public void Ekle(TEntity entity)
        {
            using (TContex ctx=new TContex())
            {
                ctx.Entry(entity).State = EntityState.Added;
                ctx.SaveChanges();
            }
        }

        public List<TEntity> Liste()
        {
            using (TContex ctx = new TContex())
            {
                IQueryable<TEntity> dbSet = ctx.Set<TEntity>();
                return dbSet.ToList();
            }
            
        }
    }
}
