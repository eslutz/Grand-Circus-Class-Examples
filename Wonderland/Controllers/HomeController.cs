using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Wonderland.Models;

namespace Wonderland.Controllers
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

		public IActionResult Blog(long id)
		{
			Blog1 blog = Blog1.Read(id);
			return View(blog);
		}

		public IActionResult Add()
		{
			ViewBag.PageName = "Add";
			return View();
		}

		public IActionResult Edit(long id)
		{
			ViewBag.PageName = "Edit";
			Blog1 blog = Blog1.Read(id);
			return View(blog);
		}

		public IActionResult SaveNew(string title, string paragraphs)
		{
			Blog1.Create(title, paragraphs);
			ViewBag.Message = "Your entry has been saved!";
			List<Blog1> blogs = Blog1.Read();
			return View("Test", blogs);
		}

		public IActionResult Test(string search)
		{
			List<Blog1> blogs = Blog1.Read(search);
			return View(blogs);
		}

		public IActionResult Test2()
		{
			Blog1.Update(4, "Part 42", "Whats the answer to the universe?");
			return Content("OK");
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
