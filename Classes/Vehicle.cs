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

    }
}
