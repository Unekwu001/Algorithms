using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Factorial
    {
        //find the factorial of a user input
        public void Facto()
        {
            string rawInput;
            int n;
            int all = 1;

            // input validation
            do
            {
                Console.WriteLine(" Enter a number. You are required to enter only digit(s)");
                rawInput = Console.ReadLine();

            }
            while (!int.TryParse(rawInput, out _));




            //factorial
            n = int.Parse(rawInput);
            do
            {
                all *= n;
                n--;
                
            }
            while (n > 1);
            Console.WriteLine(all);

        }

    }
}
