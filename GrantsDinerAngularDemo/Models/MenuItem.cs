using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrantsDinerAngularDemo.Models
{
	public class MenuItem
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Category { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
	}
}
