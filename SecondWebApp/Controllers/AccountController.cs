﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SecondWebApp.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Profile()
		{
			return View();
		}

		[HttpGet]
		public IActionResult MyProfile()
		{
			return View();
		}
	}
}
