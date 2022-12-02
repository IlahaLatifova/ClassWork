
internal class Flute : Instrument
{
    
    public override string Model { get; set; }
    public override double Price { get ; set; }
    public override string Brand { get; set; }
    public int Length { get; set; }

    public override void Sound()
    {
        Console.WriteLine("Instrument sounds like flute.");
    }
    public Flute(string model, double price, string brand, int length)
    {
        Model = model;
        Price = price;
        Brand = brand;
        Length = length;
    }
}

