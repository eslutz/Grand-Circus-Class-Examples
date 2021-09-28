using System;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Dapper.Contrib.Extensions;

namespace DapperConsole2
{
	class Program
	{
		static void Main(string[] args)
		{
			IDbConnection database = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=Northwind;user id=TestUser;password=password");
			//var result = database.Query("select * from Customers");
			var result = database.Query("CustOrderHist", new { CustomerID = "ALFKI" }, commandType: CommandType.StoredProcedure);
			foreach(var item in result)
			{
				Console.WriteLine($"{item.ProductName} {item.Total}");
			}
		}
	}
}
