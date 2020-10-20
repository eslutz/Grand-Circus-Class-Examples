using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPIDemo.Models
{
	public class Employee
	{
		public static List<Employee> Emps = new List<Employee>
		{
			new Employee { id = 0, FirstName = "Fred", LastName = "Johnson", Department = "Accounting", Salary = 80000 },
			new Employee { id = 1, FirstName = "Julie", LastName = "Smith", Department = "ID", Salary = 90000 },
			new Employee { id = 2, FirstName = "George", LastName = "Washington", Department = "Management", Salary = 100000},
			new Employee { id = 3, FirstName = "Abraham", LastName = "Lincoln", Department = "Management", Salary = 110000},
			new Employee { id = 4, FirstName = "Paul", LastName = "McCartney", Department = "Music", Salary = 10000000},
			new Employee { id = 5, FirstName = "Ringo", LastName = "Starr", Department = "Music", Salary = 900000}
		};

		public long id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Department { get; set; }
		public decimal Salary { get; set; }

		public static Employee findByID(long? id)
		{
			foreach (Employee emp in Emps)
			{
				if(emp.id == id)
				{
					return emp;
				}
			}
			return null;
		}
	}
}
