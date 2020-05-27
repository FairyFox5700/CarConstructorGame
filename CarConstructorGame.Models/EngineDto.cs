

using CarConstructorGame.Entities;
using System;
using System.Linq.Expressions;

public class EngineDto : DetailDto
{
    public double HorceForce { get; set; }
    public double CubicCapability { get; set; }

    public static Expression<Func<Engine, EngineDto>> Projection
    {
        get
        {
            return x => new EngineDto()
            {
                HorceForce = x.HorceForce,
                CubicCapability = x.CubicCapability,
                IsSuitableForRepairing = x.IsSuitableForRepairing,
                ExpluatationStabilityCoeficicent = x.ExpluatationStabilityCoef,
                RepairPrice = x.RepairPrice,
                BuyPrice = x.BuyPrice,
                CarId = x.CarId,
                DetailType = x.DetailType,
                DetailId = x.Id

            };
        }
    }
}


