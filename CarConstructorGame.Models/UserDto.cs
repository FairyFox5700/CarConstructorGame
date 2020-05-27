using System;
using System.Collections.Generic;
using System.Text;
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
        public List <CarDto>  UserCars { get; set; }
        public int UserAge  { get; set; }
    }
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
        public List<DetailDto> CarDetails { get; set; }
    }

    public abstract class DetailDto
    {
        public int DetailId { get; set; }
        public bool IsSuitableForRepairing { get; set; }
        public double RepairPrice { get; set; }
        public double BuyPrice { get; set; }
        public int CarId { get; set; }
        public DetailType DetailType { get; set; }
        public double ExpluatationStabilityCoeficicent { get; set; }
    }
    public class EngineDto: DetailDto
    {
        public double HorceForce { get; set; }
        public double CubicCapability { get; set; }
    }
    public class RimsComplectDto: DetailDto
    {
        public int Count { get; set; }
        public double Diameter { get; set; }
    }

    public class AccamulatorDto: DetailDto
    {
        public double Power { get; set; }
        public TimeSpan HoursOfWork { get; set; }
    }

}
