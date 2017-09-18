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
            Color tree = new Color(123, 233, 10, 35);
            Console.WriteLine(tree.GetAlpha());
            Console.WriteLine(tree.GrayScale());
        }
    }
}
