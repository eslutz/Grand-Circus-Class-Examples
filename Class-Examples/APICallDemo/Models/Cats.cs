using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICallDemo.Models
{
	public class Cats
	{
		public string Fact { get; set; }
		public int Length { get; set; }
		public CatDetail[] more { get; set; }
	}
}
