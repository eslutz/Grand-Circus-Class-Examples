using System;

namespace DependencyInjection
{
	class Engine
	{
		public virtual void Run()
		{
			Console.WriteLine("Engine is running");
		}
	}

	class AcmeEngine : Engine
	{
		public override void Run()
		{
			Console.WriteLine("Acme engine is running");
		}
	}

	class HighPerformanceEngine : Engine
	{
		public override void Run()
		{
			Console.WriteLine("High performance engine is running");
		}
	}

	class Car
	{
		private Engine _engine;

		public Car(Engine eng)
		{
			_engine = eng;
		}

		public void Drive()
		{
			Console.WriteLine("Car is starting up");
			_engine.Run();
			Console.WriteLine("Car is going");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Engine myEngine = new HighPerformanceEngine();
			Car myCar = new Car(myEngine);
			myCar.Drive();
		}
	}
}
