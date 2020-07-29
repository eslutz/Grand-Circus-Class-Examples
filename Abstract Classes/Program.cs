using System;

namespace Abstract_Classes
{
	abstract class Car
	{
		public abstract void Drive();
	}

	class Chevy : Car
	{
		public override void Drive()
		{
			Console.WriteLine("I'm a Chevy! And I'm driving!");
		}
	}
	sealed class Ford : Car
	{
		public override void Drive()
		{
			Console.WriteLine("I'm a Ford! And I'm driving!");
		}
	}
	
	//Cannot inherit Ford because it is sealed.
	//class Testcar : Ford { }
	 
	class Program
	{
		static void Main(string[] args)
		{
			Chevy corvette = new Chevy();
			Ford focus = new Ford();
			TestTrack(corvette);
			TestTrack(focus);
		}
	
		static void TestTrack(Car thecar)
		{
			thecar.Drive();
		}
	}
}