using System;
using shippmentapplibrary.User;
using ShippmentApplicationLibrary;
namespace Shipperapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Shipper shipper = new Shipper();
            User user = new shippmentapplibrary.User.User();
            Console.WriteLine("Hello !!!");
            Console.WriteLine("Enter the type of user:");
            Console.WriteLine("1.Shipper or 2.Driver");
            int TypeOfUser = Convert.ToInt32(Console.ReadLine());
            if (TypeOfUser != 1 && TypeOfUser != 2)
            {
                Console.WriteLine("You Have Entered Wrong Option! Please choose 1 or 2");
                Console.ReadKey();
            }
            else
            {
                if (TypeOfUser == 1)
                {
                    Console.WriteLine("Enter Details of shipper");
                    Console.WriteLine("Enter Name of the shipper:");
                    shipper.FirstName = Console.ReadLine();
                    Console.WriteLine("Enter Address:");
                    shipper.Address = Console.ReadLine();
                    Console.WriteLine("Enter Password:");
                    shipper.Password = Console.ReadLine();
                    Console.WriteLine("Enter Contactnumber:");
                    shipper.PhoneNumber = Console.ReadLine();
                    shipper.SetUser(shipper);
                    var details = shipper.GetUser();
                    Console.WriteLine("The registered User Details are\n");
                    //Too avoid righting The following lines of code use inbuilt properties
                    //Console.WriteLine(details.FirstName);
                    //Console.WriteLine(details.LastName);  
                    user.Login(details.FirstName, details.Password);
                    Console.ReadKey();
                }
                if (TypeOfUser == 2)
                {
                    Console.WriteLine("Enter Name of Driver");
                    shipper.LastName = Console.ReadLine();
                    Console.WriteLine("Enter address of Driver");
                    shipper.Address = Console.ReadLine();
                    Console.WriteLine("Enter Password of Driver");
                    shipper.Password = Console.ReadLine();
                    Console.WriteLine("Enter Contactnumber of Driver");
                    shipper.PhoneNumber = Console.ReadLine();
                    shipper.SetUser(shipper);
                    var details = shipper.GetUser();
                    Console.WriteLine("The registered Driver Details are\n");
                    user.Login(details.FirstName, details.Password);
                    Console.ReadKey();
                }
            }
        }
    }
}