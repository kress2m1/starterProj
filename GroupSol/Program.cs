using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var datatype = new Datatype();
            //datatype.TypesOfData();

            //var conditionals = new Conditionals();
            //conditionals.Sample();

            var volvo = new Car();
            volvo.PrototypeCar(4);

            var truck =  new Car();
            truck.PrototypeCar(2);
        }
    }
}
