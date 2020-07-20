using System;

namespace Methods
{
	class Program
	{
		static void Main(string[] args)
		{
			//Log("Getting ready!");
			//int num1 = 10, num2 = 15;
			//int num3 = Add(num1, num2);
			//Console.WriteLine($"The sum of {num1} and {num2} is {num3}.");
			//Log(num3.ToString());
			//Log("All done!");
			//Log(num3);

			//int a = 10, b = 20;
			//Console.WriteLine($"Pre Swap a: {a}, b: {b}");
			//Swap(ref a, ref b);
			//Console.WriteLine($"Post Swap a: {a}, b: {b}");

			int num = 5;
			Console.WriteLine($"The factorial of {num}! is {Factorial(num)}");

		}

		//Recursion with factorials!
		static int Factorial(int number)
		{
			if (number == 0)
			{
				return 1;
			}
			else
			{
				return number * Factorial(number - 1);
			}
		}

		//Swaps the value of two numbers by reference.
		static void Swap(ref int x, ref int y)
		{
			int temp = x;
			x = y;
			y = temp;
		}

		//Adds two integers that are passed to it and returns the sum.
		static int Add(int x, int y)
		{
			int total = x + y;
			return total;
		}

		//Void does not return anything.
		static void Log(string message)
		{
			Console.WriteLine(DateTime.Now);
			Console.WriteLine(message);
		}

		//Overloaded Log method to accept integers.
		static void Log(int number)
		{
			Console.WriteLine(DateTime.Now);
			Console.WriteLine(number);
		}
	}
}