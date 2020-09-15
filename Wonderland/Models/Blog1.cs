using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;

namespace Wonderland.Models
{
	public class Blog1
	{
		public long id { get; set; }
		public string Paragraphs { get; set; }
		public string Title { get; set; }
	}
}
