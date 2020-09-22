using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using APICallDemo.Models;
using System.Net.Http;

namespace APICallDemo.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public async Task<IActionResult> Test()
		{
			//HttpClient client = new HttpClient();
			//client.BaseAddress = new Uri("https://catfact.ninja");
			//var response = await client.GetAsync("/fact");
			//var catstring = await response.Content.ReadAsStringAsync();
			//Console.WriteLine(catstring);
			//return Content(catstring);

			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri("https://catfact.ninja");
			var response = await client.GetAsync("/fact");
			Cats info = await response.Content.ReadAsAsync<Cats>();
			return View(info);
		}

		public IActionResult Test1()
		{
			Response.ContentType = ("text/html");
			return Content("<b>Hello</b>");
		}

		public IActionResult Test2()
		{
			return RedirectToAction("Test3");
		}

		public IActionResult Test3()
		{
			return Content("Hello test 3!");
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
