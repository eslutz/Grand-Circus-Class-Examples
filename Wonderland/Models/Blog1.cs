using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Data;
using Dapper;

namespace Wonderland.Models
{
	[Table("Blog1")]
	public class Blog1
	{
		[Key]
		public long ID { get; set; }
		public string Paragraphs { get; set; }
		public string Title { get; set; }
	
		//Create


		//Read
		static public List<Blog1> Read()
		{
			IDbConnection database = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=devbuild1;user id=TestUser;password=password");
			List<Blog1> blogs = database.GetAll<Blog1>().ToList();
			return blogs;
		}

		static public Blog1 Read(long id)
		{
			IDbConnection database = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=devbuild1;user id=TestUser;password=password");
			Blog1 blog = database.Get<Blog1>(id);
			return blog;
		}

		static public List<Blog1> Read(string search)
		{
			IDbConnection database = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=devbuild1;user id=TestUser;password=password");
			List<Blog1> blogs = database.Query<Blog1>($"select id, title from Blog1 where paragraphs like '%{search}%'").ToList();
			return blogs;
		}

		//Update


		//Delete
		public static void Delete(long id)
		{
			IDbConnection database = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=devbuild1;user id=TestUser;password=password");
			database.Delete(new Blog1() { ID = id });
		}
	}
}