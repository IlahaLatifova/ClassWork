using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegister
{
    internal class User
    {
        private string _id;
        public string UserName
        {
            get { return _id; }
            set
            {
                while(value.Length < 8)
                {
                    Console.WriteLine("Please, enter the username again: ");
                    value = Console.ReadLine();
                }
                _id = value;
            }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                int count = 0;
                while(true)
                {
                    /*for (int i = 0; i < value.Length; i++)
                    {
                        if (Char.IsDigit(value[i]))
                        {
                            count++;
                        }
                    }
                    while(value.Length < 8 || count == 8)
                    {

                    }*/
                    while (value.Length < 8)
                    {
                        Console.WriteLine("Please, enter the username again: ");
                        value = Console.ReadLine();
                    }
                    _id = value;

                }
                
            }
        }

        public User(string username,string password)
        {
            UserName = username;
            Password = password;
        }
        public User()
        {

        }
    }
}
