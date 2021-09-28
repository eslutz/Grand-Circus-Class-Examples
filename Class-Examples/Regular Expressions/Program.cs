using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
	class Program
	{
		static void Main(string[] args)
		{
			//regular expressions for comparing strings
			Regex reg = new Regex(@"ABC.{3,}XYZ");
			Regex reg2 = new Regex(@"^ABC.{3,}XYZ$");
			string myString = "ABC&(^q*!XYZ";
			string myString2 = "hjustrysgyABC&(%XYZsdfgsdfghs";
			bool match = reg.IsMatch(myString);
			bool match2 = reg.IsMatch(myString2);
			bool match3 = reg2.IsMatch(myString2);
			Console.WriteLine($"{reg} {myString} {match}");
			Console.WriteLine($"{reg} {myString2} {match2}");
			Console.WriteLine($"{reg2} {myString2} {match3}");

			//case insensitive
			string[] names = {
				"ABCDEFGHIXYZ",
				"ABC   XYZ",
				"ABC123 XYZ",
				"abc   xyz"
			};
			Regex reg3 = new Regex(@"ABC.*XYZ", RegexOptions.IgnoreCase);
			foreach (string name in names)
			{
				bool match4 = reg3.IsMatch(name);
				Console.WriteLine();
				Console.WriteLine(name);
				Console.WriteLine(match4);
			}
		}
	}
}
