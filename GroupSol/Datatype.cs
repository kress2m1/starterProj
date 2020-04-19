using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSol
{
    public class Datatype
    {
        public void TypesOfData()
        {
            var untrue = false;
            const string name = "Andre";
            var doubleVar = 20.5D;
            var integerVar = 11;
            var floatVar = 50F;

            var a = 2;
            var b = 6;

            Console.WriteLine(name);
            Console.WriteLine(untrue);
            Console.WriteLine(doubleVar);
            Console.WriteLine(integerVar);
            Console.WriteLine(floatVar);

            Console.WriteLine("My name is " + name + " and I live at number " + integerVar);

            Console.WriteLine(integerVar * 2);

            var c = a * b;
            var d = b - a;
            Console.WriteLine(c);

            // this is a single line comment

            /**
             * This is a
             * multiline
             * comment
             */

            var thisIsADouble = 10.25;
            var castToInt = (int) thisIsADouble;

        }
    }
}
