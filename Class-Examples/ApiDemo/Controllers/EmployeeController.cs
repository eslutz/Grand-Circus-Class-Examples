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
	public class EmployeeController : ControllerBase
	{
		[HttpGet]
		public List<Employee> Emp()
		{
			List<Employee> emps = new List<Employee>();
			Employee emp1 = new Employee() { UserID = "42", Name = "Dwight Schrute", Deptartment = "Sales" };
			Employee emp2 = new Employee() { UserID = "47", Name = "Creed Bratton", Deptartment = "Quality Assurance" };
			emps.Add(emp1);
			emps.Add(emp2);
			return emps;
		}

		[HttpGet("{userid}")]
		public Employee Emp(string userid)
		{
			Employee emp1 = new Employee() { UserID = userid, Name = "Dwight Schrute", Deptartment = "Sales" };
			return emp1;
		}
	}
}
