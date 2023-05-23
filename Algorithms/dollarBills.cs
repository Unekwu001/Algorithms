using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	internal class DollarBills
	{
		//Given an amount of cash between $40 and $10000 (with $10000 included ) and assuming that the ATM
		//wants to use as few bills as possible, determine the minimal number of 100,50,20 dollar bills the
		//ATM machine needs to dispense (in that order).
		public void Bills(int number)
		{
			int countOfHundred;
			int countOffifty;
			int countOfTwenty;

			if (number % 100 == 0)
			{
				countOfHundred = number/100;
				countOffifty = 0; 
				countOfTwenty = 0;
				Console.WriteLine($"{countOfHundred}, {countOffifty}, {countOfTwenty}");
			}
			else if (number % 50 == 0) 
			{
				countOfHundred = (number - 50)/100;
				countOffifty = 1;
				countOfTwenty = 0;
				Console.WriteLine($"{countOfHundred}, {countOffifty}, {countOfTwenty}" );
			}
			else if (number % 20 == 0)
			{
				countOfHundred = number / 100;
				countOffifty = 0;
				countOfTwenty = 1;
				Console.WriteLine($"{countOfHundred}, {countOffifty}, {countOfTwenty}");
			}
			else
			{
				countOfHundred = ((number+50)/ 100)-1;
				countOffifty = 1;
				countOfTwenty = ((number+50)%100)/20;
				Console.WriteLine($"{countOfHundred}, {countOffifty}, {countOfTwenty}");

			}
			 
		}

	}
}
