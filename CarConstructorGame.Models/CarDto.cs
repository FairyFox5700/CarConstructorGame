

using CarConstructorGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

public class CarDto
{
    public int CarId { get; set; }
    public CarDto()
    {
        this.CarDetails = new List<DetailDto>();
    }
    public bool IsMoving { get; set; }
    public double Distance { get; set; }
    public double TotalCost { get; set; }
    public int UserId { get; set; }
    public IEnumerable<DetailDto> CarDetails { get; set; } = new List<DetailDto>();
    public static Expression<Func<Car, CarDto>> Projection
    {
        get
        {
            return x => new CarDto()
            {
                CarId = x.Id,
                IsMoving = x.IsMoving,
                Distance = x.Distance,
                TotalCost = x.TotalCost,
                UserId = x.UserId,
                //CarDetails = x.Details.AsQueryable().Select()
                //CarDetails
            };
        }
    }
}


