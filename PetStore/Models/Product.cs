using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace PetStore.Models
{
	[Table("Product")]
	public class Product
	{
		[Key]
		public long ID { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }

		//Create
		public static Product Create(string _name, Decimal _price)
		{
			//Create the new Product instance
			Product prod = new Product() { Name = _name, Price = _price };

			//Save it to the database
			IDbConnection db = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=PetStore;user id=TestUser;password=password");
			long _id = db.Insert<Product>(prod);

			//Set the id column of the instance
			prod.ID = _id;

			//Return the instance
			return prod;
		}

		//Read
		public static Product Read(long id)
		{
			IDbConnection db = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=PetStore;user id=TestUser;password=password");
			Product prod = db.Get<Product>(id);
			return prod;
		}

		public static List<Product> Read()
		{
			IDbConnection db = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=PetStore;user id=TestUser;password=password");
			List<Product> prods = db.GetAll<Product>().ToList();
			return prods;
		}

		//Update
		public void Save()
		{
			IDbConnection db = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=PetStore;user id=TestUser;password=password");
			db.Update(this);
		}

		//Delete
		public static void Delete(long id)
		{
			IDbConnection db = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=PetStore;user id=TestUser;password=password");
			db.Delete(new Product() { ID = -id });
		}
	}
}
