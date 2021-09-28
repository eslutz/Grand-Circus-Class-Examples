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

		//URL path: /api/Employees/1
		[HttpGet("{id}")]
		public Employee GetSingle(long id)
		{
			return Employee.findByID(id);
		}
	}
}
