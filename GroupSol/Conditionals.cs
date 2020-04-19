using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSol
{
    public class Conditionals
    {
        public void Sample()
        {
            var a = 2;
            var b = 6;

            if (a > b)
            {
                Console.WriteLine(a + " is greater than " + b);
            }
            else if (a == b)
            {
                Console.WriteLine(a + " is equal to " + b);
            }
            else if (a < b)
            {
                Console.WriteLine(a + " is less than " + b);
            }
            else
            {
                Console.WriteLine("I don't know what else to do");
            }
        }
    }
}
