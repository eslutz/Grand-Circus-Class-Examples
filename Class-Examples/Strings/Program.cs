using System;
using System.Text;

namespace Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			string word1 = "Test";
			string word2 = "TEST";

			if (String.Equals(word1, word2, StringComparison.CurrentCultureIgnoreCase))
			{
				Console.WriteLine($"{word1} and {word2} are the same.");
			}

			if (String.Compare(word1, word2, true) == 0)
			{
				Console.WriteLine($"{word1} and {word2} are the same.");
			}

			Console.WriteLine(word1.Equals(word2));

			string word3 = "Grand Circus";
			Console.WriteLine(word3.Substring(6, 3));

			StringBuilder builder = new StringBuilder();
			builder.Append("Hello ");
			builder.Append("World!");
			builder.Append("\nHow's it going?");
			builder.Insert(0, "\n");
			builder.Replace('o', 'X');
			builder.Replace(" ", ",_");
			string newString = builder.ToString();
			Console.WriteLine(newString);
		}
	}
}
