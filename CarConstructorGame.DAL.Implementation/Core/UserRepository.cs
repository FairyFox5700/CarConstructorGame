using CarConstructorGame.DAL.Abstract;
using CarConstructorGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarConstructorGame.DAL.Implementation.Core
{
    public class UserRepository : BaseRepository<User, int>, IUserRepository
    {
        public UserRepository(CarGameContext context) : base(context)
        {
        }
    }
}
