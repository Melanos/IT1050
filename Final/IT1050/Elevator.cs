using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IT1050
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            MaxWeight = maxWeight;
        }

        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }
        public double GetCurrentWeight()
        {
            double currenWeight = 0D;
            foreach (Passenger passanger in Occupants)
            {
                currenWeight += passanger.Weight;
            }

            return currenWeight;
        }
        public bool IsOverMaxCapacity()
        {
            return (GetCurrentWeight() > MaxWeight);          
        }
    }
}
