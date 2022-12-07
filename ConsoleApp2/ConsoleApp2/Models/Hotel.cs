
internal class Hotel
{
    public string Name { get; set; }
    public static Room[] rooms = new Room[0];
    public Hotel(string name)
    {
        Name = name;
    }

    public Room this[int index]
    {
        get => rooms[index];
        set => rooms[index] = value;
    }
}

