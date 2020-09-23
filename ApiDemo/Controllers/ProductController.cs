using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDemo.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		//Use "Get" mehtod name for default route
		//product?word=Steve
		[HttpGet]
		public List<string> Get(string word)
		{
			List<string> result = new List<string>();
			result.Add("Root");
			result.Add("Path");
			if (word != null)
			{
				result.Add(word);
			}
			return result;
		}

		//product/demo?word=Steve
		[HttpGet("Demo")]
		public List<string> Demo(string word)
		{
			List<string> result = new List<string>();
			result.Add("Hello");
			result.Add("World");
			if (word != null)
			{
				result.Add(word);
			}
			return result;
		}

		//product/demo/Steve
		//[HttpGet("Demo/{userid}")]
		//public List<string> Demo2(string userid)
		//{
		//	List<string> result = new List<string>();
		//	result.Add("Hello");
		//	result.Add("World");
		//	result.Add(userid);
		//	return result;
		//}

		//product/demo/Steve
		//product/demo/Steve?word=Steve
		[HttpGet("Demo/{userid}")]
		public List<string> Demo3(string userid, string word)
		{
			List<string> result = new List<string>();
			result.Add("Hello");
			result.Add("World");
			result.Add(userid);
			if(word != null)
			{
				result.Add(word);
			}
			return result;
		}
	}
}
