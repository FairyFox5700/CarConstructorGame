using CarConstructorGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarConstructorGame.DAL.Abstract
{
    public interface IUserRepository:IRepository<User,int>
    {
        public async Task<User> GetUserByName(string userName);
    }
}
