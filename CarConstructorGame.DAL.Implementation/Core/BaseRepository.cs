using CarConstructorGame.DAL.Abstract;
using CarConstructorGame.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarConstructorGame.DAL.Implementation.Core
{
    public abstract class BaseRepository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        private readonly CarGameContext context;
        DbSet<TEntity> dbSet;
        private DbSet<TEntity> DBSet
        {
            get { return dbSet ?? (dbSet = context.Set<TEntity>()); }
        }
        public BaseRepository(CarGameContext context)
        {
            this.context = context;
        }
        public virtual void Add(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            DBSet.Add(entity);
        }

        public virtual void Delete(TEntity entity)
        {

            var dbEntityEntry = this.context.Entry(entity);
            if (dbEntityEntry.State != EntityState.Detached)
            {
                dbEntityEntry.State = EntityState.Deleted;
            }
            else
            {
                DBSet.Attach(entity);
                DBSet.Remove(entity);
            }
        }


        public virtual void Update(TEntity entity)
        {
            DBSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;

        }

        public virtual  async Task<TEntity> GetById(TKey id)
        {
            return await DBSet.FindAsync(id);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await DBSet.AsNoTracking().ToListAsync();
        }
    }
}
