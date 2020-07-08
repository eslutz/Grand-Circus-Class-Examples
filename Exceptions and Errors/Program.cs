using System;

namespace Exceptions_and_Errors
{
	class Program
	{
		static void Main(string[] args)
		{
			//try catch example
			string entry = Console.ReadLine();
			try
			{
				int number = int.Parse(entry);
				Console.WriteLine(number);
			}
			catch
			{
				Console.WriteLine("That was not a valid number.");
			}
			Console.WriteLine("All done.");

			//try catch math example
			int q = 10;
			int r = 0;
			try
			{
				int number2 = q / r;
				Console.WriteLine(number2);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.StackTrace);
				Console.WriteLine(e.Message);
			}
			Console.WriteLine("All done");
			

			//catching different types of exceptions
			string entry2 = Console.ReadLine();
			try
			{
				int number3 = int.Parse(entry2);
				Console.WriteLine(number3);
			}
			catch (FormatException e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine("Please only enter integers.");
			}
			catch (OverflowException e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine("Please enter a smaller number.");
			}
			Console.WriteLine("All done");

			//exception catching in a method
			string entry3 = Console.ReadLine();
			try
			{
				int number4 = DoEntry(entry3);
				Console.WriteLine(number4);
			}
			catch (FormatException e)
			{
				Console.WriteLine("Please only enter integers.");
				Console.WriteLine(e);
			}
			catch (OverflowException)
			{
				Console.WriteLine("Please enter a smaller number.");
			}
			Console.WriteLine("All done");

			//tryparse and throwing exceptions
			string entry4 = Console.ReadLine();
			if (int.TryParse(entry4, out int number5))
			{
				Console.WriteLine(number5);
			}
			else
			{
				Console.WriteLine("That is not a valid number.");
				throw new Exception("That is not a valid number.");
			}
			Console.WriteLine("All done");
		}

		//exception catching in a method
		public static int DoEntry(string entry)
		{
			int result = int.Parse(entry);
			return result;
		}
	}
}
