using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
     class Algos
        {
            public void SumOfDigits()
            {
                string rawInput;
                int sumAll = 0;
                int processedInput;
                int lastNumber;

                //Write a program to find the sum of digits of an integer number, inputed by the user.

                //This do while loop validates the user input.
                do
                {
                    Console.WriteLine(" Enter a number. You are required to enter only digit(s)");
                    rawInput = Console.ReadLine();

                }
                while (!int.TryParse(rawInput, out _));

                
                processedInput = int.Parse(rawInput);

                while (processedInput > 0)
                {
                    lastNumber = processedInput % 10;
                    sumAll = sumAll + lastNumber;
                    processedInput = processedInput / 10;
                }
                Console.WriteLine(sumAll);
            }
        }
    }

