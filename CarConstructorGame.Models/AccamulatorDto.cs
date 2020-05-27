

using CarConstructorGame.Entities;
using System;
using System.Linq.Expressions;

public class AccamulatorDto : DetailDto
    {
        public double Power { get; set; }
        public TimeSpan HoursOfWork { get; set; }


        public static Expression<Func<Accamulator, AccamulatorDto>> Projection
        {
            get
            {
                return x => new AccamulatorDto()
                {
                    Power = x.Power,
                    HoursOfWork = x.HoursOfWork,
                    IsSuitableForRepairing = x.IsSuitableForRepairing,
                    RepairPrice = x.RepairPrice,
                    BuyPrice = x.BuyPrice,
                    CarId = x.CarId,
                    DetailType = x.DetailType,
                    DetailId = x.Id,
                    ExpluatationStabilityCoeficicent = x.ExpluatationStabilityCoef
                };
            }
        }
    }
}


