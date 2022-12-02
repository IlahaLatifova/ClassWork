
internal class Piano : Instrument
{
    public override string Model { get ; set ; }
    public override double Price { get ; set; }
    public override string Brand { get; set; }
    public string type { get; set; }
    public override void Sound()
    {
        Console.WriteLine("Instrument sounds like piano.");
    }
    public Piano(string model, double price, string brand,string type)
    {
        Model = model;
        Price = price;
        Brand = brand;
        this.type = type;
    }
}

