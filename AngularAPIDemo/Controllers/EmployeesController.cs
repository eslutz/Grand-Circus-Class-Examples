using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularAPIDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularAPIDemo.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeesController : ControllerBase
	{
		//URL path: /api/Employees
		[HttpGet]
		public IEnumerable<Employee> Get()
		{
			return Employee.Emps;
		}
	}
}
