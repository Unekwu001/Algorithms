using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
		public class Solution
		{
		//method 1 : Using Dictionary
			public static int RomanToInt(string s)
			{ 
				var myCombos = new Dictionary<char, int>(){ {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000} };

				int total = 0;
				int previousValue = 0;

				foreach (char letter in s)
				{
					int value = myCombos[letter];
					total += value;

					if (value > previousValue)
					{
						total = total  - (2 * previousValue);
					}

					previousValue = value;
				}
				return total;
			}



		//Method 2 : Using HashTable.
		public static int _RomanToInt(string romanNumerals)
		{
			var myCombos = new Hashtable() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };

			int total = 0;
			int previousValue = 0;

			foreach (char letter in romanNumerals)
			{
				int value = myCombos.ContainsKey(letter) ? (int)myCombos[letter] : 0;
				//To check if a character is a valid Roman numeral, we use the ContainsKey method of the combos Hashtable.If the key exists, we retrieve the value using (int) combos[letter]. Otherwise, we assign a value of 0.

				total += value;

				if (value > previousValue)
				{
					total = total - (2 * previousValue);
				}

				previousValue = value;
			}
			return total;
		}



		//Method 3 : Olawale Odeyemi
		public int Roman_ToInt(string s)
		{
			Dictionary<char, int> myCombos = new Dictionary<char, int>{ {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}};

			int result = 0;

			for (int i = 0; i < s.Length; i++)
			{
				if ((i < s.Length - 1) && myCombos[s[i]] < myCombos[s[i + 1]])
				{
					result = result - myCombos[s[i]];
				}
				else
				{
					result = result - myCombos[s[i]];
				}
			}

			return result;
		}







		public static int ConvertRoman(string romans)
		{
			var myCombos = new Hashtable() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };

			int total = 0;
			int previousValue = 0;
			foreach (char letter in romans)
			{
				int value = myCombos.ContainsKey(letter) ? (int)myCombos[letter] : 0;

				if (value > previousValue)
				{
					total = total - (2 * previousValue);
				}
				
				total = total + value;
				previousValue = value;
			}
			return total;
		}










	}
}
