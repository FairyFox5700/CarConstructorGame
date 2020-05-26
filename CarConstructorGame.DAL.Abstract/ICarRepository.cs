using CarConstructorGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarConstructorGame.DAL.Abstract
{
    public interface ICarRepository : IRepository<Car, int>
    {
    }
}
