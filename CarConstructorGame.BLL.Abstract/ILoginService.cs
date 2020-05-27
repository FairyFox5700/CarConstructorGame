using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarConstructorGame.BLL.Abstract
{
    public interface ILoginService
    {
        public Task<LoginResponce> LoginUserByUserName(string username);
    }
    public class LoginResponce
    { }

}
