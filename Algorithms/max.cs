using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class MaxElement
    {
        //method 1
        //        public void Maxdigit(int[] digits)
        //      {
        //       int max = digits[0];
        //      for (int i = 1;i < digits.Length; i++)
        //    {
        //      if (digits[i] > max)
        //    { 
        //      max = digits[i];
        //}
        // }
        //Console.WriteLine("The maximum digit in the list is " + max);

        //}

        //method 2
        public void Maxdigit(int[] digits)
        {
            Array.Sort(digits);
            
            int lastDigitandHighest = digits[digits.Length - 1];
            int firstdigitandSmallest = digits[0];
            Console.WriteLine($"the last digit is {lastDigitandHighest} and the first digit is {firstdigitandSmallest}");


        }
    }
}
