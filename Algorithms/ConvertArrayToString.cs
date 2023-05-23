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

			string k = string.Join("", num);
			int a = int.Parse(k);
			int b = a + 1;
			string c = string.Join("", b);
			int[] x = new int[c.Length];
			for (int i = 0; i < c.Length; i++)
			{
				x[i] = Convert.ToInt32(c[i].ToString());
			}
			return x;

		}
	}
}
