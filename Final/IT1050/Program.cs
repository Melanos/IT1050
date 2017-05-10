using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace IT1050
{
    class Program
    {
        public static Elevator elevator1;
        public static Elevator elevator2;
        public static bool elevator1IsOverMaxCapacity;
        public static bool elevator2IsOverMaxCapacity;

        static void Main(string[] args)
        {
            // For elevator 1
            elevator1 = new Elevator(2, 400);
            elevator1.AddOccupant(new Passenger("A1", 180), 0);
            elevator1.AddOccupant(new Passenger("A2", 220), 1);
            elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();
            Debug.WriteLine("Is Overweight: " + elevator1IsOverMaxCapacity);

            //For elevator 2
            elevator2 = new Elevator(3, 600);
            elevator2.AddOccupant(new Passenger("A1", 200), 0);
            elevator2.AddOccupant(new Passenger("A2", 200), 1);
            elevator2.AddOccupant(new Passenger("A3", 201), 2);
            elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();
            Debug.WriteLine("Is Overweight: " + elevator2IsOverMaxCapacity);
        }
    }
}
