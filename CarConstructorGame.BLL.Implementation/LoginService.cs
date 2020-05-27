using CarConstructorGame.BLL.Abstract;
using CarConstructorGame.DAL.Abstract;
using CarConstructorGame.Entities;
using CarConstructorGame.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static CarConstructorGame.Common.Enums;

namespace CarConstructorGame.BLL.Implementation
{
    public class LoginService : ILoginService
    {
        private const int TotalSumForStart = 10000;
        private readonly IUnitOfWork unitOfWork;

        public LoginService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<UserDto> LoginUserByUserName(string username)
        {
            var user= await unitOfWork.UserRepository.GetUserByName(username);
            return UserDto.FromUserEntity(user);
        }
        public  RegisterUser(string username)
        {
            var userDto = new UserDto()
            {
                UserAge = 2,
                UserName = username,
                TotalSum = TotalSumForStart,
                GameRating = GameRating.ActivePlayer
            };
 
           unitOfWork.UserRepository.Add(UserDto.FromUserDto(userDto));
        }
    }
}
