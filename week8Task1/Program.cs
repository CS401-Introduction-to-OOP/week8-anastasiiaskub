namespace week8Task1;

class Program
{
    static void Main(string[] args)
    {
        Letter let1 = new Letter("267", 4);
        Letter let2 = new Letter("123", 20);

        Parcel parcel1 = new Parcel("345", 45, "20X10X30");
        Parcel parcel2 = new Parcel("678", 5, "10X5X20");

        DeliveryItem item1 = let1;
        DeliveryItem item2 = parcel2;
        
        item1.PrintInfo();
        item2.PrintInfo();

        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
        myCargo.AddItem(let1);
        myCargo.AddItem(let2);
        myCargo.AddItem(parcel1);
        myCargo.AddItem(parcel2);
        myCargo.AddItem(item1);
        myCargo.AddItem(item2);

        Console.WriteLine($"total cost: {myCargo.GetTotalCost()}");
    }
}