using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n Greetings user, please enter your VIN number: ");
            string VIN = Console.ReadLine();
            Console.Write("\n Please enter the driver's name: ");
            Vehicle spider = new Vehicle("diononooqwenf", "Dog");
            spider.SetDriver(Console.ReadLine());
            spider.GetDriver();
            spider.GetVehicle();   
            Console.WriteLine(" Thank you for your participation.\n");
        }
    }
}
