using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Vehicle
    {
        private string VIN;
        private string Driver;

        public Vehicle(string VIN, string Driver)
        {
            this.VIN = VIN;
            this.Driver = Driver;
        }

        public Vehicle()
        {
        }

        public string GetDriver()
        {
            Console.WriteLine($"\n Driver Name: {Driver}\n");
            return Driver;
        }

        public void SetDriver(string Driver)
        {
            this.Driver = Driver;
        }

        public void GetVehicle()
        {
            if(this.Driver != null)
                Console.WriteLine($" Driver Name: {Driver}\n");

            if (this.VIN != null)
                Console.WriteLine($" Driver VIN: {VIN}\n");
        }
    }
}
