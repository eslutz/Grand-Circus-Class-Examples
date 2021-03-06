﻿using System;
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

		public Blog1() { }
		
		public Blog1(string title, string para)
		{
			Title = title;
			Paragraphs = para;
		}
		//Create
		public static void Create(string _title, string _paragraphs)
		{
			Blog1 blog = new Blog1(_title, _paragraphs);
			IDbConnection database = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=devbuild1;user id=TestUser;password=password");
			database.Insert(blog);
		}

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

		public static List<Blog1> Read(string search)
		{
			IDbConnection database = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=devbuild1;user id=TestUser;password=password");
			List<Blog1> blogs = database.Query<Blog1>($"select id, title from Blog1 where paragraphs like '%{search}%'").ToList();
			return blogs;
		}

		//Update
		public static void Update(long _id, string _title, string _paragraphs)
		{
			Blog1 blog = new Blog1() { ID = _id, Title = _title, Paragraphs = _paragraphs};
			IDbConnection database = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=devbuild1;user id=TestUser;password=password");
			database.Update(blog);
		}

		//Delete
		public static void Delete(long id)
		{
			IDbConnection database = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=devbuild1;user id=TestUser;password=password");
			database.Delete(new Blog1() { ID = id });
		}

		public static long TestProc()
		{
			IDbConnection database = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=devbuild1;user id=TestUser;password=password");
			int result = database.QuerySingle<int>("AddBlog", new { paragraphs = "test", title = "test" }, commandType: CommandType.StoredProcedure);
			return result;
		}
	}
}