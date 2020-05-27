using CarConstructorGame.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarConstructorGame.BLL.Abstract
{
    public interface ILoginService
    {
        public Task<UserDto> LoginUserByUserName(string username);
        public void RegisterUser(UserDto user);
    }
   

}
