using CarConstructorGame.DAL.Abstract;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarConstructorGame.DAL.Implementation.Core
{
    //TODO implement methods for transaction properly
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public UnitOfWork(IUserRepository userRepository, ICarRepository carRepository, ICarDetailsRepository carDetailsRepository, CarGameContext context)
        {
            UserRepository = userRepository;
            CarRepository = carRepository;
            CarDetailsRepository = carDetailsRepository;
            this.context = context;
        }
        private IDbContextTransaction transaction;
        private readonly CarGameContext context;
        public IUserRepository UserRepository { get; }
       
        public ICarRepository CarRepository { get; }

        public ICarDetailsRepository CarDetailsRepository { get; }

        public async  Task CommitAsync()
        {
           await  transaction.CommitAsync();
        }

        public async  Task RollbackAsync()
        {
            await transaction.RollbackAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }

        public async  Task StartAsync()
        {
            transaction = await context.Database.BeginTransactionAsync();
          
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
