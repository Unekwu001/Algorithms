using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	internal class endsWith
	{
		public string EndsWith(int input )
		{
			if (input.ToString().EndsWith("11") || input.ToString().EndsWith("12") || input.ToString().EndsWith("13")) return input + "st";
			else if (input.ToString().EndsWith("1")) return input + "st";
			else if (input.ToString().EndsWith("2")) return input + "nd";
			else if (input.ToString().EndsWith("3")) return input + "rd";
			else return input + "th";
		}
	}
}
