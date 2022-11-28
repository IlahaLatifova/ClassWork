using LoginRegister;

AccountService accountService = new AccountService();   
while (true)
{
    Console.WriteLine("Please,choose one of this options: ");
    Console.WriteLine("Choose 1 for registration. \nChoose 2 for sign in. \n Choose 0 for exit.");
    int option = Convert.ToInt32(Console.ReadLine());

    if(option == 1)
    {
        Console.WriteLine("Enter the student name: ");
        string username = Console.ReadLine();
        Console.WriteLine("Enter the student surname: ");
        string password = Console.ReadLine();

        User user = new User(username,password);
        Console.WriteLine(accountService.Register(user);
    }
}