using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FourthWebApp.Models;
using System.Text.RegularExpressions;

namespace FourthWebApp.Controllers
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

		[HttpGet]
		public IActionResult Register()
		{

			return View();
		}
		
		[HttpPost]
		public IActionResult Register(string Username, string FirstName, string Email)
		{
			Regex validText = new Regex(@"^[A-Za-z]+$");
			Account act;
			if (!(validText.IsMatch(Username) && validText.IsMatch(FirstName)))
			{
				if (!validText.IsMatch(Username) && !validText.IsMatch(FirstName))
				{
					ViewBag.ErrorMessage = "Enter a valid username and first name.";
					act = new Account() { Email = Email, FirstName = "", Username = "" };
					return View(act);
				}
				else if (!validText.IsMatch(FirstName))
				{
					ViewBag.ErrorMessage = "Enter a valid first name.";
					act = new Account() { Email = Email, FirstName = "", Username = Username };
					return View(act);
				}
				else
				{
					ViewBag.ErrorMessage = "Enter a valid username.";
					act = new Account() { Email = Email, FirstName = FirstName, Username = "" };
					return View(act);
				}

			}
			act = new Account() { Email = Email, FirstName = FirstName, Username = Username };
			return View("RegisterResponse", act);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
