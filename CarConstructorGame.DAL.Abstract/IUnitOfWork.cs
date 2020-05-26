using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarConstructorGame.DAL.Abstract
{
    public interface IUnitOfWork
    {
        public Task<int> SaveChangesAsync(); 
        Task StartAsync(); 
        Task CommitAsync(); 
        Task RollbackAsync();
        public IUserRepository UserRepository { get; }
        public ICarRepository CarRepository { get;  }
    }
}
