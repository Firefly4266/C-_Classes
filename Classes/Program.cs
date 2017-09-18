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
            Random random = new Random();
            Console.Write("\n Greetings user, please enter the number of times to roll the die: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int count = 0, total = 0;
           
            while (count < userInput)
            {
                int userRoll = random.Next(6) + 1;
                total += userRoll;
                count++;
                Console.WriteLine(userRoll);
            }
            Console.WriteLine(total);
        }
    }
}
