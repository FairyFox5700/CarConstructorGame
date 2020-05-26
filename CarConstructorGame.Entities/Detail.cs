using static CarConstructorGame.Entities.Enums.Enums;

namespace CarConstructorGame.Entities
{
    public abstract class Detail : BaseEntity<int>
    {
        public bool IsSuitableForRepairing { get; set; }
        public double RepairPrice { get; set; }
        public double BuyPrice { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public DetailType DetailType { get; set; }
        public double ExpluatationStabilityCoef { get; set; }
       
    }
}
