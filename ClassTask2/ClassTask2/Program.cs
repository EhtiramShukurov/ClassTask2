using ClassTask2.Models;

namespace ClassTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Jake", 400, true);
            Employee employee2 = new Employee("Angela", 600, true);
            Employee employee3 = new Employee("George", 1000, false);
            Employee employee4 = new Employee("Michael", 200, true);
            Assistant assistant = new Assistant();
            assistant.GetFeedback(employee);
            assistant.GetFeedback(employee2);
            assistant.GetFeedback(employee3);
            assistant.GetFeedback(employee4);

        }
    }
}