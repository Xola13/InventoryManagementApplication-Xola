using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApplication
{
	public class Car
	{
		public string Make {  get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string VIN {  get; set; }
		public decimal Price { get; set; }

		// De-Constructor
		~Car() { }

		public override string ToString()
		{
			return $"Make: {Make}, Model: {Model}, Year: {Year}, VIN: {VIN}, Price: {Price.ToString("C", new CultureInfo("en-ZA"))}";
		}
	}
}
