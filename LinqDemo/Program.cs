using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
	class Info
	{
		public int ID { get; set; }
		public string Name { get; set; }
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<Info> items = new List<Info>();
			items.Add(new Info() { ID = 1, Name = "Dwight" });
			items.Add(new Info() { ID = 2, Name = "Mose" });
			items.Add(new Info() { ID = 3, Name = "Jim" });
			items.Add(new Info() { ID = 4, Name = "Pam" });
			items.Add(new Info() { ID = 5, Name = "Ryan" });
			items.Add(new Info() { ID = 6, Name = "Creed" });



			foreach(Info item in items)
			{
				Console.WriteLine(item.Name);
			}
		}
	}
}
