using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;

namespace PetStore.Models
{
	public class Product
	{
		[Key]
		public long ID { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }

		//Create

		//Read

		//Update

		//Delete
	}
}
