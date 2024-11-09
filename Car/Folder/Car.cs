using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string Color { get; set; }

        public void Ride() {

            Console.WriteLine("The car is riding");
        
        }

        public void Parked()
        {
            Console.WriteLine("The car is parked in current time");
        }

    }
}
