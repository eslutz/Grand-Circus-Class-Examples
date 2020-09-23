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
			items.Add(new Info() { ID = 7, Name = "Pam" });
			items.Add(new Info() { ID = 5, Name = "Ryan" });
			items.Add(new Info() { ID = 6, Name = "Creed" });

			//List<Info> results = items.Where(x => x.ID > 2).ToList();
			//var results = items.Where(x => x.ID > 2).OrderBy(x => x.ID);
			var results = (from item in items where item.ID > 2 select item).OrderBy(x => x.ID);

			foreach(Info item in results)
			{
				Console.WriteLine(item.Name);
			}
		}
	}
}
