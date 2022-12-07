/*Room room1 = new Room("Ilaha",1050,4);
Room room2 = new Room("Ahali", 500, 2);

HotelService hotelService = new HotelService();
hotelService.AddRoom(room1);
hotelService.AddRoom(room2);
Console.WriteLine(room1);
*/
HotelService hotelService = new HotelService();
Console.WriteLine("Please, choose one of this options: ");
start:
Console.WriteLine("1 - for adding room to Hotel\n0 - for quit");
int option = Convert.ToInt32(Console.ReadLine());
if (option == 1)
{
    Console.WriteLine("Please enter the name of room: ");
    string roomName = Console.ReadLine();
    Console.WriteLine("Enter price of room: ");
    double price = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter capacity of room: ");
    int capacity = Convert.ToInt32(Console.ReadLine());
    Room room = new Room(roomName, price, capacity);
    hotelService.AddRoom(room);
}
else if (option == 0) { Console.WriteLine("Quit"); }
else
{
    Console.WriteLine("Enter 1 or 0");
    goto start;
}


while (option != 0)
{
    Console.WriteLine("\n*******************************************\n1 - for adding new room\n2 - for showing room info\n3 - making reservation\n*******************************************\n");
    option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            Console.WriteLine("Please enter the name of room: ");
            string roomName = Console.ReadLine();
            Console.WriteLine("Enter price of room: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter capacity of room: ");
            int capacity = Convert.ToInt32(Console.ReadLine());
            Room room = new Room(roomName, price, capacity);
            hotelService.AddRoom(room);
            break;
        case 3:
            try
            {
                Console.WriteLine("Enter id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                hotelService.MakeReservation(id);   
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;

    }
}
