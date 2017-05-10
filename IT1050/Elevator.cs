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
            // Another version of doing the same thing with 'for' loop instead of 'foreach'
            // Choose whaever version suit you the most

            //for (int i = 0; i < Occupants.Length; i++)
            //{
            //    currenWeight += Occupants[i].Weight;
            //}
            return currenWeight;
        }
        public bool IsOverMaxCapacity()
        {
            return (GetCurrentWeight() > MaxWeight);
            // Another version of doing the same thing, but the longer, more obvious way
            // Choose whaever version suit you the most

            //if (GetCurrentWeight() > MaxWeight)
            //    return true;
            //else
            //    return false;            
        }
    }
}
