using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IT1050
{
    class Passenger
    {
        public string Name;
        public double Weight;

        public Passenger(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetWeight()
        {
            return Weight;
        }
    }
}
