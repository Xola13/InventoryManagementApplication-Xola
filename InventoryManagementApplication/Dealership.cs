using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApplication
{
	public class Dealership
	{
		private static List<Car> _inventory = new List<Car>();
		public static int TotalCars = _inventory.Count;


		// Method to add cars

		public static void AddCar(string make, string model, int year, string vin, decimal price)
		{
			AddCar(make, model, year, vin, price, null);
		}

		// Overloaded Method of adding cars with optional features

		public static void AddCar(string make, string model, int year, string vin, decimal price, string optionalFeatures)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(vin))
					throw new ArgumentNullException(nameof(vin), "VIN cannot be null or empty");

				if (_inventory.Any(car => car.VIN == vin))
					throw new ArgumentException("A car with the same VIN already exists.");

				if (year < 1886 || year > DateTime.Now.Year)
					throw new FormatException("Year is invalid");


				Car newCar = new Car
				{
					Make = make,
					Model = model,
					Year = year,
					Price = price,
				};

				_inventory.Add(newCar);
				Console.WriteLine("Car added successfully");
			}
			catch (ArgumentNullException ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
			}
			catch (FormatException ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"An unexpected error occurred: {ex.Message}");
			}
		}

		// Recursive method to search for a car by VIN

		public static Car SearchCarByVIN(string vin)
		{
			return SearchCarByVIN(vin, 0);
		}

		private static Car SearchCarByVIN(string vin, int index)
		{
			if (index >= _inventory.Count)
				return null;

			if (_inventory[index].VIN.Equals(vin, StringComparison.OrdinalIgnoreCase))
				return _inventory[index];

			return SearchCarByVIN(vin, index + 1);
		}

		public static void DisplayInventory()
		{
			if(_inventory.Count == 0)
			{
				Console.WriteLine("No cars in inventory.");
			}
			else
			{
				Console.WriteLine("Current Inventory: ");

				foreach (var car in _inventory)
				{
					Console.WriteLine(car);
				}
			}
		}
	}
}
