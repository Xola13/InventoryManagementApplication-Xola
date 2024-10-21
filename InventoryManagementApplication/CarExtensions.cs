using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApplication
{
	public static class CarExtensions
	{
		public static void DisplayDetails(this Car car)
		{
			Console.WriteLine(car.ToString());
		}
	}
}
