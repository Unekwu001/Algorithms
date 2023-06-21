using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	internal static class ObjectList
	{
		public static void HandleObjectList()
		{
			 
			List<Object> objModels = new List<Object>() 
			{
			new { Name = "Manish", Age = 27, Sports = "Cricket" },
			new { Name = "Rajan", Age = 25, Sports = "FootBall" },
			new { Name = "Prashant", Age = 25, Sports = "Kabaddi" },
			new { Name = "Garima", Age = 24, Sports = "Ludo" },
			new { Name = "Neha", Age = 25, Sports = "Carom"  } 
			};

			foreach (Object obj in objModels) 
			{ 
				 //if (obj)
				Console.WriteLine(obj); 
			}
		}
	}
}
