using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegister
{
    internal class AccountService
    {
        User[] users = new User[0]; 
        public void Register(User newUser)
        {
            if (users[users.Length-1] == null)
            {
                int count = 0;
                foreach (var user in users)
                {
                    if(newUser != user) { count++; }
                }
                if(count == users.Length)
                {
                    Array.Resize(ref users, count++);
                    users[users.Length-1] = newUser;
                }
                else
                {
                    Console.WriteLine("This account already exists.\nIf you want you can log in your account. ");

                }
            }
        }

        public void LogIn(User newUser)
        {
            int count = 0;
            foreach (var user in users)
            {
                if(newUser == user)
                {
                    count++;
                    Console.WriteLine("Log in your account");
                    break;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("This acount does not exist, please sign up.");
            }
        }

        public AccountService()
        {

        }
    }
}
