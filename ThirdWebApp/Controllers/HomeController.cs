using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThirdWebApp.Models;

namespace ThirdWebApp.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public ActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Save(string username, string email, string password)
		{
			WebUser user = new WebUser() { Username = username, Email = email, Password = password };

			return View();
		}
	}
}