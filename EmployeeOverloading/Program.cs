using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeModel junior = new EmployeeModel("Benjamin", "Naidoo", 72, "IT", 40000);

            EmployeeModel contractor = new EmployeeModel("Tim", "Corey");
            Console.WriteLine($"{contractor.FirstName} has id {contractor.EmployeeId}");

            EmployeeModel intermediate = new EmployeeModel(junior);
            Console.WriteLine($"Intermediate copied junior: {intermediate.EmployeeId}, {intermediate.MonthlySalary}");
        }
    }
}
