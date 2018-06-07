using System;
using System.Collections.Generic;
using System.Text;

namespace shippmentapplibrary.User
{
    public class User
    {
        public string Name;
        public string UserId;
        private string UserName { get; set; }
        private string Password { get; set; }
        public string PhoneNumber { get; set; }
        public void Signup(string username, String password)
        {
            Console.WriteLine("enter id:");
            UserId = Console.ReadLine();
            Console.WriteLine("enter password:");
            Password = Console.ReadLine();
            if (UserName == username)
            {
                if (Password == password)
                    Console.WriteLine("You are logged");
            }
            else
                Console.WriteLine("ERROR!! Log in failed");
            Console.ReadKey();
        }
    }
}

