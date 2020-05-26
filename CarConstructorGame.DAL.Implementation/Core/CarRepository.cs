using CarConstructorGame.DAL.Abstract;
using CarConstructorGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarConstructorGame.DAL.Implementation.Core
{
    public class CarRepository : BaseRepository<Car, int>, ICarRepository
    {
        public CarRepository(CarGameContext context) : base(context)
        {
        }
    }
}
