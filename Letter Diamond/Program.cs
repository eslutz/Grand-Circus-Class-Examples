using System;

namespace Letter_Diamond
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter a letter: ");
			char letter = char.Parse(Console.ReadLine().ToUpper());

			char[] letters = "ABCDEFGHIJKLMNOPQRSTUBWXYZ".ToCharArray();
			int charIndex = Array.IndexOf(letters, letter);

			string[] diamond = new string[((charIndex) * 2) + 1];
			for (int z = 0; z <= charIndex; z++)
			{
				//add initial spaces
				for (int j = 0; j < charIndex - z; j++)
				{
					diamond[z] += "-";
				}

				//add letter (first time)
				diamond[z] += letters[z];

				//add space between letters
				if (letters[z] != 'A')
				{
					for (int j = 0; j < 2 * z - 1; j++)
					{
						diamond[z] += "-";
					}
					//add letter (second time)
					diamond[z] += letters[z];
				}

				//add end spaces
				for (int j = 0; j < charIndex - z; j++)
				{
					diamond[z] += "-";
				}

			}
			// Draw the second part of the diamond
			// Writing the diamondArray in reverse order.
			for (int i = charIndex; i >= 0; i--)
			{
				diamond[charIndex + i] = diamond[charIndex - i];
			}

			Console.WriteLine();
			foreach (string x in diamond)
			{
				Console.WriteLine(x);
			}
		}
	}
}
