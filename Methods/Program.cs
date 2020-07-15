using System;

namespace Methods
{
	class Program
	{
		static void Main(string[] args)
		{
			Log("Getting ready!");
			int num1 = 10, num2 = 15;
			int num3 = Add(num1, num2);
			Console.WriteLine($"The sum of {num1} and {num2} is {num3}.");
			Log(num3.ToString());
			Log("All done!");
			Log(num3);
		}

		//Adds two integers that are passed to it and returns the sum.
		static int Add(int x, int y)
		{
			int total = x + y;
			return total;
		}

		//void does not return anything
		static void Log(string message)
		{
			Console.WriteLine(DateTime.Now);
			Console.WriteLine(message);
		}

		//overloaded Log method to accept integers
		static void Log(int number)
		{
			Console.WriteLine(DateTime.Now);
			Console.WriteLine(number);
		}
	}
}
