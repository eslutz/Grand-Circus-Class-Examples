using System;

namespace Classes
{
	class Spaceship
	{
		private string Name;
		private string ShipType;
		private bool FTLCapable;
		private double CrewCapacity;

		public Spaceship(string name, string type, bool ftlCapable, double crew)
		{
			Name = name;
			ShipType = type;
			FTLCapable = ftlCapable;
			CrewCapacity = crew;
		}

		public double Travel()
		{
			double distanceTraveled = 10000;
			return distanceTraveled;
		}

		public string GetShip()
		{
			return ShipType + " " + Name;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Spaceship ship = new Spaceship("Galactica", "Battlestar", true, 5000);
			
			Console.WriteLine(ship.GetShip());
			Console.WriteLine($"The ship moved: {ship.Travel()}");
		}
	}
}