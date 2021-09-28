using System;

namespace Circle_Radius
{
	class Program
	{
		static void Main(string[] args)
		{
			// Asks the user for a the radius for a circle and then takes in the input.
			Console.WriteLine("Enter the radius. =>");
			string input = Console.ReadLine();
			// Converts the input from a string to a double.
			double radius;
			bool validNumber = double.TryParse(input, out radius);
			while (!validNumber)
			{
				Console.WriteLine("Invalid input. Please enter a number. =>");
				input = Console.ReadLine();
				validNumber = double.TryParse(input, out radius);
			}
			if (radius < 0)
			{
				Console.WriteLine("You entered a negative number, but I'll compute the radius anyway.");
			}
			// Computes the area of a circle and prints out the result.
			double area = Math.PI * Math.Pow(radius, 2);
			Console.WriteLine($"The area of the circle is {area:N2}");
			Console.WriteLine("Now enter a height the radius. =>");
			input = Console.ReadLine();
			double height;
			validNumber = double.TryParse(input, out height);
			while (!validNumber)
			{
				Console.WriteLine("Invalid input. Please enter a number. =>");
				input = Console.ReadLine();
				validNumber = double.TryParse(input, out height);
			}
			area = Math.PI * Math.Pow(radius, 2) * height;
			Console.WriteLine($"The volume of the circle is {area:N2}");
		}
	}
}
