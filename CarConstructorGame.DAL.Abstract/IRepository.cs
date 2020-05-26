using CarConstructorGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarConstructorGame.DAL.Abstract
{
    public interface IRepository<TEntity,TKey> where TEntity : BaseEntity<TKey>
    {
        //TODO Add pagination
        Task<TEntity> GetAll();
        Task<TEntity> GetById(TKey id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
