
internal class HotelService : IHotelService
{

    public void AddRoom(Room newroom)
    {

        foreach (var room in Hotel.rooms)
        {
            if (room == newroom)
            {
                Console.WriteLine("This room is already exist.");
                return;
            }

        }
        Array.Resize(ref Hotel.rooms, Hotel.rooms.Length + 1);
        Hotel.rooms[Hotel.rooms.Length - 1] = newroom;
        Console.WriteLine("Room added to Hotel,succesfully.");

    }

    public void MakeReservation(int? roomId)
    {
        if (roomId == null)
        {
            throw new NotAvailableException("This id format is not true!!!");
        }
        foreach (var room in Hotel.rooms)
        {
            if (room.Id == roomId)
            {
                if (room.IsAvailable)
                {
                    room.IsAvailable = false;
                    Console.WriteLine("Reservation is done succesfully");
                }
                else
                {
                    throw new NotAvailableException("This room is reserved!!!");
                }
            }
        }
    }
}

