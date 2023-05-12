using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class MaxElement
    {
        public void Maxdigit(int[] digits)
        {
           int max = digits[0];
            for (int i = 1;i < digits.Length; i++)
            {
                if (digits[i] > max)
                { 
                    max = digits[i];
                }
            }
        Console.WriteLine(max);

        }
    }
}
