using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask2.Models
{
    internal class Manager
    {
        protected Employee GetPromotion(Employee employee)
        {
            employee.Salary += 100;
            Console.WriteLine($"Salary of {employee.Name} increased to {employee.Salary}");
            return employee;
        }
    }
}
