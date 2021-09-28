using System;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace DapperConsole
{
	class Categories
	{
		public int CategoryID { get; set; }
		public string CategoryName { get; set; }
		public string Description { get; set; }
	}
	class Program
	{
		static void Main(string[] args)
		{
			//IDbConnection database = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=Northwind;user id=TestUser;password=password");
			IDbConnection database = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=Northwind;Trusted_Connection=Yes");
			
			database.Open();

			List<Categories> cats = database.Query<Categories>("select * from Categories").AsList<Categories>();

			foreach(Categories cat in cats)
			{
				Console.WriteLine($"{cat.CategoryID} {cat.CategoryName} {cat.Description}");
			}

			database.Close();
		}
	}
}
