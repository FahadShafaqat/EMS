using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_Form
{
    public class Employee
    {
        public string EmployeeID { get; set; } = "";
        public string EmployeeName { get; set; } = "";
        public string EmployeePosition { get; set; } = "";
        public decimal EmployeeSalary { get; set; } = 0m;

       

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}, Employee Name: {EmployeeName}, Employee Position: {EmployeePosition}, Employee Salary: {EmployeeSalary}");
        }

       
    }
}
