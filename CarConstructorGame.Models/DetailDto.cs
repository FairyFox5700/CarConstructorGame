using static CarConstructorGame.Common.Enums;

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


