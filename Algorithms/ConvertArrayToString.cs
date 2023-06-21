using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleK
{
	public static class Challenge
	{

		public static int[] UpArray(int[] num)
		{

			string k = string.Join("", num);//converts array to a string
			int a = int.Parse(k);  //converts string to int.
			int b = a + 1;      //add 1 to the int.
			string c = string.Join("", b); //converting it back to string
			int[] x = new int[c.Length];   //an empty array was inintialised to collect the "i" items below
			for (int i = 0; i < c.Length; i++)
			{
				x[i] = Convert.ToInt32(c[i].ToString());
			}
			return x;

		}
	}
}
