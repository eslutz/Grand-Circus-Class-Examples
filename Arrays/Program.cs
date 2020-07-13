using System;

namespace Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter a number => ");
			string entry = Console.ReadLine();
			int numberCount = int.Parse(entry);

			int[] numbers = new int[numberCount];

			for (int x = 0; x < numberCount; x++)
			{
				numbers[x] = x * 5;
				Console.WriteLine(numbers[x]);
			}

			int[] more = { 120, 10, 50, 30, 80, 10, 10, 20, 100 };
			int[] more2 = { 120, 10, 50, 30, 80, 10, 10, 20, 100 };
			Array.Sort(more);
			// Now our array is this:
			// 10, 20, 30, 50, 80, 100, 120

			//this works for a sorted array
			int index = Array.BinarySearch(more, 20);
			if (index < 0)
			{
				Console.WriteLine("Not found");
			}
			else
			{
				Console.WriteLine($"Found at location {index}.");
			}

			//finds the first instance of searched value
			int index2 = Array.IndexOf(more2, 20);
			if (index < 0)
			{
				Console.WriteLine("Not found");
			}
			else
			{
				Console.WriteLine($"Found at location {index2}.");
			}

			//finds the third instance of searched value
			int index3 = Array.IndexOf(more2, 20);
			int count = 0;
			for (int x = 0; x < more2.Length; x++)
			{
				if (more2[x] == 10)
				{
					count++;
					if (count == 3)
					{
						Console.WriteLine(x);
						break;
					}
				}
			}

			//multidimensional arrays
			int[,] numbers2 = { { 10, 20 }, { 50, 30 }, { 80, 20 }, { 90, 10 } };

			for (int row = 0; row < 4; row++)
			{
				for (int col = 0; col < 2; col++)
				{
					Console.WriteLine(numbers2[row, col]);
				}
			}

			//jagged arrays
			int[][] numbers3 = new int[4][];
			numbers3[0] = new int[] { 10, 20, 30 };
			numbers3[1] = new int[] { 50, 20, 10 };
			numbers3[2] = new int[] { 1, 10 };
			numbers3[3] = new int[] { 5 };
			for (int i = 0; i < numbers3.Length; i++)
			{
				Console.WriteLine();
				Console.WriteLine(numbers3[i].Length);
				for (int j = 0; j < numbers3[i].Length; j++)
				{
					Console.WriteLine(numbers3[i][j]);
				}
			}
		}
	}
}
