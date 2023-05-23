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
			int countOfHundreds;
			int countOffiftys;
			int countOfTwentys;

			if (number % 100 == 0)
			{
				countOfHundreds = number/100;
				countOffiftys = 0; 
				countOfTwentys = 0;
				Console.WriteLine($"{countOfHundreds}, {countOffiftys}, {countOfTwentys}");
			}
			else if (number % 50 == 0) 
			{
				countOfHundreds = (number - 50)/100;
				countOffiftys = 1;
				countOfTwentys = 0;
				Console.WriteLine($"{countOfHundreds}, {countOffiftys}, {countOfTwentys}" );
			}
			else if (number % 20 == 0)
			{
				countOfHundreds = number / 100;
				countOffiftys = 0;
				countOfTwentys = 1;
				Console.WriteLine($"{countOfHundreds}, {countOffiftys}, {countOfTwentys}");
			}
			else
			{
				countOfHundreds = ((number+50)/ 100)-1;
				countOffiftys = 1;
				countOfTwentys = ((number+50)%100)/20;
				Console.WriteLine($"{countOfHundreds}, {countOffiftys}, {countOfTwentys}");

			}
			 
		}

	}
}
