using CarConstructorGame.DAL.Abstract;
using CarConstructorGame.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConstructorGame.DAL.Implementation.Core
{
    public class UserRepository : BaseRepository<User, int>, IUserRepository
    {
        private readonly CarGameContext context;

        public UserRepository(CarGameContext context) : base(context)
        {
            this.context = context;
        }

        public async  Task<User> GetUserByName(string userName)
        {
            //var quety =  from  users in context.Users
            //            join cars in context.Cars
            //            on users.Id equals cars.Id
            //             select all;
            return await context.Users.AsQueryable().Include(u=>u.Cars).FirstOrDefaultAsync(u => u.UserName==userName);
        }
    }
}
