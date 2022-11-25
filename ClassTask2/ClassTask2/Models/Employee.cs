using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask2.Models
{
    internal class Employee
    {
		string _name;
		double _salary;


		public string Name
		{
			get { return _name; }
			set {
				value = value.Trim();
				if (value.Length > 2 && value.Length <20)
				{
                    _name = value;
                }
			}
		}
		public bool IsSuccesful { get; set; }
		public double Salary
		{
			get { return _salary; }
			set {

				if (value>=300)
				{
                    _salary = value;
                }
				}
		}
		public Employee(string name, double salary,bool isSuccesful)
		{
			Name = name;
			Salary = salary;
			IsSuccesful = isSuccesful;
		}
	}
}
