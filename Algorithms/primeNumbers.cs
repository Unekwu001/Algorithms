using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class PrimeNumbers
    {
        public void PrimeNums() 
        {
            string rawInput;
            int n;
            int x;

            //input validation that checks if the string is of int elements.
            do
            {
                Console.Clear();
                Console.WriteLine(" Enter a number. You are required to enter only digit(s)");
                rawInput = Console.ReadLine();

            }
            while (!int.TryParse(rawInput, out _));

            //Given a number N, the task is to print the prime numbers from 1 to N.
           
            n = int.Parse(rawInput);
            string all = "";
            for(x=1; x < n; x++ ) 
            { 
               all = all + x;
                 
            }
        }
    }
}
