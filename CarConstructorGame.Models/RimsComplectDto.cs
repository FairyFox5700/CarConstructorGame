

using CarConstructorGame.Entities;
using System;
using System.Linq.Expressions;
public class RimsComplectDto : DetailDto
{
    public int Count { get; set; }
    public double Diameter { get; set; }


    public static Expression<Func<RimsComplect, RimsComplectDto>> Projection
    {
        get
        {
            return x => new RimsComplectDto()
            {
                Count = x.Count,
                Diameter = x.Diameter,
                IsSuitableForRepairing = x.IsSuitableForRepairing,
                RepairPrice = x.RepairPrice,
                BuyPrice = x.BuyPrice,
                CarId = x.CarId,
                DetailType = x.DetailType,
                ExpluatationStabilityCoeficicent = x.ExpluatationStabilityCoef,
                DetailId = x.Id

            };
        }
    }

}



