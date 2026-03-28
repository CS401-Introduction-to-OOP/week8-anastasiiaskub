namespace week8Task1;

public class Letter : DeliveryItem
{
    public Letter(string trackingNumber, double weight) : base(trackingNumber, weight)
    {
        
    }

    public override double CalculateCost()
    {
        if (Weight < 0)
        {
            throw new Exception("the weight is incorrect");
        }
        return  15 + Weight * 25;
    }
}