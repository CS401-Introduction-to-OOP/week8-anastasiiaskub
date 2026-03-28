namespace week8Task1;

public class CargoContainer<T> where T: DeliveryItem
{
    private List<T> list = new List<T>();

    public void AddItem(T item)
    {
        list.Add(item);
        Console.WriteLine($"{item} is added");
    }
    
    public double GetTotalCost()
    {
        double total = 0;
        foreach (var item in list)
        {
            total += item.CalculateCost();
        }
        return total;
    }
}