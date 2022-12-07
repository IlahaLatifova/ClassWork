using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Room
{
    private static int _id;
    public int Id;
    public string Name { get; set; }
    public double Price { get; set; }
    public int PersonCapacity { get; set; }
    public bool IsAvailable = true;
    public Room(string name, double price, int personcapacity)
    {
        _id++;
        Id = _id;
        Name = name;
        Price = price;
        PersonCapacity = personcapacity;
        
    }
    public string ShowInfo()
    {
        return ToString();
    }
    public override string ToString()
    {
        return $"\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nName: {Name}     Price: {Price}     Person capacity: {PersonCapacity}\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
    }

}

