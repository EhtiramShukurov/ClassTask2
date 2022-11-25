using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask2.Models
{
    internal class Assistant:Manager
    {
        public void GetFeedback(Employee employee)
        {
            if (employee.Name == null || employee.Salary == 0)
            {
                Console.WriteLine("Wrong input");
            }
            else if (employee.IsSuccesful && employee.Name != null && employee.Salary != 0)
            {
                Console.WriteLine($"{employee.Name} is succesful.");
                GetPromotion(employee);
            }
            else
            {
                Console.WriteLine($"{employee.Name} is not succesful.");
            }
        }
    }
}
