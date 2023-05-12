using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //var obj = new Algos();
            //obj.SumOfDigits();

            //var obj = new Factorial();
            //obj.Facto();
            int[] plenty = {2,3,78,89,4,3,4 };
            var obj = new MaxElement();
            obj.Maxdigit(plenty);
        }
    }

    
}
