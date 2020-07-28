using System;
using System.Collections.Generic;

namespace Properties
{
	class Department
	{
		private string _name;
		private string _manager;

		public string Name
		{
			get { return _name; }
		}

		public string Manager
		{
			get { return _manager; }
			set
			{
				if(value != "Douglas Reynholm"  && value != "Jen Barber")
				{
					return;
				}
				else
				{
					_manager = value;
				}
			}
		}

		public Department(string name, string manager)
		{
			_name = name;
			_manager = manager;
		}

		public string getName()
		{
			return _name;
		}

		public void setManager(string manager)
		{
			if (manager != "Douglas Reynholm" && manager != "Jen Barber")
			{
				return;
			}
			else
			{
				_manager = manager;
			}
		}

		public string getManager()
		{
			return _manager;
		}
	}

	class Employee
	{
		//static keyword attached variable or method to the class itself.
		private static int NumberOfEmployees;
		private static List<Employee> Employees = new List<Employee>();

		private string _name;
		private decimal _salary;
		private string _department;

		public string Name
		{
			get => _name;
			set => _name = value;
		}
		public decimal Salary
		{
			get => _salary;
			set => _salary = value;
		}
		public string Department
		{
			get => _department;
			set => _department = value;
		}

		public Employee(string name, Decimal salary, string department)
		{
			_name = name;
			_salary = salary;
			_department = department;
			Employee.NumberOfEmployees++;
			Employee.Employees.Add(this);
		}

		public static void Stats()
		{
			Console.WriteLine($"There are {Employee.NumberOfEmployees/*or Employee.Employees.Count*/} employees.");
			foreach (Employee emp in Employee.Employees)
			{
				Console.WriteLine(emp);
			}
		}

		public static int GetEmployeeCount()
		{
			return Employee.Employees.Count;
		}

		public override string ToString()
		{
			return $"{Name}, {Department}, {Salary}";
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Department executive = new Department("Executive", "Douglas Reynholm");
			Department IT = new Department("IT", "Jen Barber");
			new Employee("Roy Trenneman", 50000, "IT");
			new Employee("Maurice Moss", 55000m, "IT");
			new Employee("Richmond Avenal", 60000m, "IT");

			Console.WriteLine($"The name of the department is {IT.getName()}.");
			Employee.Stats();
			Console.WriteLine(Employee.GetEmployeeCount());
		}
	}
}
