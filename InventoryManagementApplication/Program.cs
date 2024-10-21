using System;

namespace InventoryManagementApplication
{
	public class Program
	{
		public static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("\nCar Dealership Inventory Management Application");
				Console.WriteLine("1. Add Car");
				Console.WriteLine("2. Search Car by VIN");
				Console.WriteLine("3. Display Inventory");
				Console.WriteLine("4. Exit");
				Console.Write("Choose an option: ");
				string choice = Console.ReadLine();

				switch (choice)
				{
					case "1":
						AddCar();
						break;
					case "2":
						SearchCar();
						break;
					case "3":
						Dealership.DisplayInventory();
						break;
					case "4":
						return;
					default:
						Console.WriteLine("Invalid choice, please try again.");
						break;
				}
			}
		}

		private static void AddCar()
		{
			Console.Write("Enter Make: ");
			string make = Console.ReadLine();

			Console.Write("Enter Model: ");
			string model = Console.ReadLine();

			Console.Write("Enter Year: ");
			int year = int.Parse(Console.ReadLine());

			Console.Write("Enter VIN: ");
			string vin = Console.ReadLine();

			Console.Write("Enter Price: ");
			decimal price = decimal.Parse(Console.ReadLine());

			Dealership.AddCar(make, model, year, vin, price);
		}

		private static void SearchCar()
		{
			Console.Write("Enter VIN to search: ");
			string vin = Console.ReadLine();

			if(string.IsNullOrEmpty(vin))
			{
				Console.WriteLine("VIN cannot be empty.");
				return;
			}

			var searchedCar = Dealership.SearchCarByVIN(vin);

			if (searchedCar != null)
			{
				Console.WriteLine("Car found: ");
				searchedCar.DisplayDetails();
			}
			else
			{
				Console.WriteLine("Car not found.");
			}
		}
	}
}