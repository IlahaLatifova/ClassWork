
internal class Violent : Instrument
{
    public override string Model { get; set ; }
    public override double Price { get; set ; }
    public override string Brand { get; set; }
    public string material { get; set; }

    public override void Sound()
    {
        Console.WriteLine("Instrument sounds like violent.");
    }
}

