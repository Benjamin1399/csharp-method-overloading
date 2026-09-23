namespace EmployeeOverloading
{
    public class EmployeeModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int EmployeeId { get; set; }

        public string Department { get; set; }

        public decimal MonthlySalary { get; set; }

        public EmployeeModel(EmployeeModel employeeToCopy)
        {
            FirstName = employeeToCopy.FirstName;
            LastName = employeeToCopy.LastName;
            Department = employeeToCopy.Department;
            MonthlySalary = employeeToCopy.MonthlySalary;
            EmployeeId = (int)EmployeeIdSequence.BaseId + 1;
        }
        public EmployeeModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeeId = (int)EmployeeIdSequence.BaseId + 1;
            Department = "Unassigned";
            MonthlySalary = 0;
        }

        public EmployeeModel(string firstName, string lastName, int employeeId, string department, decimal monthlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeeId = employeeId;
            Department = department;
            MonthlySalary = monthlySalary;
        }
    }
}
