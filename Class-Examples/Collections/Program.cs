using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
	class Program
	{
		static void Main(string[] args)
		{
			ArrayList mylist = new ArrayList();
			mylist.Add("Hello");
			mylist.Add("Goodbye");
			mylist.Add("Everyone");
			//mylist.Add(7);
			//mylist.Add('d');
			//mylist.Add(true);
			//mylist.Add(19.56);
			for (int index = 0; index < mylist.Count; index++)
			{
				Console.WriteLine(mylist[index]);
			}
			//doesn't work with the commented out lines
			for (int index = 0; index < mylist.Count; index++)
			{
				string current = (string)mylist[index];
				Console.WriteLine(current);
			}
			Console.WriteLine();

			ArrayList mylist2 = new ArrayList();
			mylist2.Add(10);
			mylist2.Add(15);
			mylist2.Add(50);
			mylist2.Add(100);
			for (int index = 0; index < mylist2.Count; index++)
			{
				int current = (int)mylist2[index];

				Console.WriteLine(current);
			}
			Console.WriteLine();

			ArrayList mylist3 = new ArrayList();
			mylist3.Add(10);
			mylist3.Add(15);
			mylist3.Add(50);
			mylist3.Add(100);
			mylist3.Add(200);
			mylist3.Add(220);
			mylist3.Add(200);
			mylist3.Add(300);
			mylist3.Add(200);
			mylist3.Add(2000);
			// Remove the number 200 from the list, which is index 4
			//removes the provided object at first occurrence
			//mylist3.Remove(200);
			//remove at removes object at provided index
			//mylist3.RemoveAt(4);
			//removes all instances of provided object
			while (mylist3.Contains(200))
			{
				mylist3.Remove(200);
			}
			
			for (int index = 0; index < mylist3.Count; index++)
			{
				int current = (int)mylist3[index];
				Console.WriteLine(current);
			}
			Console.WriteLine();

			Hashtable items = new Hashtable();
			items["apple"] = 20;
			items["banana"] = 10;
			Console.WriteLine("==first==");
			Console.WriteLine($"There are {items["apple"]} apples left.");
			Console.WriteLine($"There are {items["banana"]} bananas left.");
			items["apple"] = (int)items["apple"] - 2;
			Console.WriteLine();
			Console.WriteLine("==After selling two apple==");
			Console.WriteLine($"There are {items["apple"]} apples left.");
			Console.WriteLine($"There are {items["banana"]} bananas left.");
			Console.WriteLine();

			Hashtable items2 = new Hashtable();
			items2["apple"] = 20;
			items2["banana"] = 10;
			items2["pear"] = 10;
			items2["strawberry"] = 10;
			foreach(DictionaryEntry item in items2)
			{
				Console.WriteLine($"There are {item.Value} {item.Key}s available");
			}
			Console.WriteLine();
			foreach (var key in items2.Keys)
			{
				Console.WriteLine($"There are {items2[key]} {key}s available");
			}
			Console.WriteLine();

			Dictionary<string, int> items3 = new Dictionary<string, int>();
			items3["apple"] = 20;
			items3["banana"] = 10;
			items3["pear"] = 15;
			items3["strawberry"] = 30;
			Console.WriteLine(items3.ContainsKey("apple"));
			Console.WriteLine(items3.ContainsKey("orange"));
			Console.WriteLine(items3.ContainsValue(20));
			Console.WriteLine(items3.ContainsValue(40));
			foreach (KeyValuePair<string, int> item in items3)
			{
				Console.WriteLine($"There are {item.Value} {item.Key}s available");
			}
		}
	}
}
