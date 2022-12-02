
internal class Guitar : Instrument
{
    public override string Model { get ; set; }
    public override double Price { get; set; }
    public override string Brand { get; set ; }
    public int year { get; set; }
    public override void Sound()
    {
        Console.WriteLine("Instrument sounds like guitar.");
    }
    public Guitar(string model, double price, string brand, int year)
    {
        Model = model;
        Price = price;
        Brand = brand;
        this.year = year;
    }
}

