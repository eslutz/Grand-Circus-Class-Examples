using System;

namespace Loop
{
	class Program
	{
		static void Main(string[] args)
		{
			//for loop
			Console.WriteLine("The loop is about to start");
			for (int x = 3; x < 30; x += 7)
			{
				Console.WriteLine($"The loop is running {x}");
			}
			Console.WriteLine("The loop has ended");

			//while loop
			bool keepGoing = true;
			while (keepGoing)
			{
				Console.WriteLine("Looped");
				Console.WriteLine("Continue? (y/n):");
				string goOn = Console.ReadLine();
				if (goOn == "n" || goOn == "N")
				{
					keepGoing = false;
				}
				else if (goOn != "y" && goOn != "Y")
				{
					Console.WriteLine("That's not valid input.");
					Console.WriteLine("Defaulting to no.");
					keepGoing = false;
				}
			}

			//do while loop
			int count = 0;
			do
			{
				Console.WriteLine(count);
				count++;
			} while (count < 10);
			Console.WriteLine("All done.");
			Console.WriteLine(count);

			//foreach loop
			int[] sizes = { 156, 456, 786, 468, 763, 896 };
			foreach (int size in sizes)
			{
				Console.WriteLine(size);
			}

			//loop exercise
			double[] sizes2 = { 10.5, 20.12, 100.543, 1234.12345, 50.24542 };
			foreach (double size in sizes2)
			{
				Console.WriteLine($"The current number is {size:N2}.");
			}
		}
	}
}
