using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectionStringDemo.Models
{
	[Table("Blog1")]
	public class Blog2
	{
		[Key]
		public long ID { get; set; }
		public string Paragraphs { get; set; }
		public string Title { get; set; }

		public static List<Blog2> Read(IDbConnection database)
		{
			List<Blog2> result = database.GetAll<Blog2>().ToList();
			return result;
		}
	}
}
