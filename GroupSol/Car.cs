using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GroupSol
{
    public class Car
    {
        private int numDoors;
        private int numTyres;
        private int numWindshield;
        private string carColour;

        public void PrototypeCar(int d)
        {
            numDoors = d;
            Console.WriteLine("This car has " + d + " doors");
        }
    }
}
