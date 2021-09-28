using ConnectionStringDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace ConnectionStringDemo.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private IDbConnection _database;

		public HomeController(ILogger<HomeController> logger, IDbConnection database)
		{
			_logger = logger;
			_database = database;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public IActionResult Blog()
		{
			List<Blog2> result = Blog2.Read(_database);
			return Content(result.Count.ToString());
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}