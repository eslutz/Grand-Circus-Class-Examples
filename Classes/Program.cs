using System;
using System.Collections.Generic;

namespace Classes
{
	class Spaceship
	{
		private string name;
		private string shipType;
		private bool _FTLCapable;
		private double crewCapacity;

		public string Name
		{
			get { return name; }
		}
		public string ShipType { get; set; }
		public bool FTLCapable { get { return _FTLCapable; } set { _FTLCapable = value; } }
		public double CrewCapacity
		{
			get { return crewCapacity; }
			set { crewCapacity = value; }
		}
		

		public Spaceship()
		{
			name = "unnamed";
			shipType = "unknown";
			_FTLCapable = false;
			CrewCapacity = 0;
		}
		
		public Spaceship(string name, string type, bool ftlCapable, double crew)
		{
			this.name = name;
			shipType = type;
			_FTLCapable = ftlCapable;
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

			Spaceship[] fleet = new Spaceship[10];
			for (int x = 0; x < fleet.Length; x++)
			{
				fleet[x] = new Spaceship();
			}
			foreach (Spaceship vessle in fleet)
			{
				Console.WriteLine(vessle.GetShip());
			}

			List<Spaceship> fleet2 = new List<Spaceship>();
			fleet2.Add(new Spaceship());
			fleet2.Add(new Spaceship("Galactica", "Battlestar", true, 5000));
			fleet2.Add(new Spaceship("Serenity ", "Firefly", false, 5));
			fleet2.Add(new Spaceship());
			fleet2.Add(new Spaceship("Rocinante ", "Gunship", false, 20));
			foreach (Spaceship vessle in fleet2)
			{
				Console.WriteLine(vessle.GetShip());
			}

			ship.CrewCapacity = 200;
			Console.WriteLine(ship.CrewCapacity);

			Console.WriteLine(ship.FTLCapable);
						ship.FTLCapable = true;
			Console.WriteLine(ship.FTLCapable);
		}
	}
}