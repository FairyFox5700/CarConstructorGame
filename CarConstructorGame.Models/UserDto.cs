

using CarConstructorGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using static CarConstructorGame.Common.Enums;

namespace CarConstructorGame.Models
{
    public class UserDto
    {
        public UserDto()
        {
            this.UserCars = new List<CarDto>();
        }
        public int UserId { get; set; }
        public double TotalSum { get; set; }
        public string UserName { get; set; }
        public GameRating GameRating { get; set; }
        public IEnumerable<CarDto> UserCars { get; set; } = new List<CarDto>();
        public int UserAge { get; set; }

        public static Expression<Func<User, UserDto>> Projection
        {
            get
            {
                return x => new UserDto()
                {
                    UserId = x.Id,
                    UserName = x.UserName,
                    GameRating = x.GameRating,
                    TotalSum = x.MoneySum,
                    UserAge = x.Age.Value,
                    UserCars = x.Cars.AsQueryable().Select(CarDto.Projection)
                };
            }
        }

        public static Expression<Func<UserDto, User>> ProjectionToEntity
        {
            get
            {
                return x => new User()
                {
                    Id = x.UserId,
                    UserName = x.UserName,
                    GameRating = x.GameRating,
                    MoneySum = x.TotalSum,
                    ///Age.Value  = x.UserAge,value object????
                    //UserCars = x.Cars.AsQueryable().Select(CarDto.Projection)
                };
            }
        }
        public static UserDto FromUserEntity(User entity)
        {
            return Projection.Compile().Invoke(entity);
        }
        public static User FromUserDto(UserDto user)
        {
            return ProjectionToEntity.Compile().Invoke(user);
        }
    }

}


