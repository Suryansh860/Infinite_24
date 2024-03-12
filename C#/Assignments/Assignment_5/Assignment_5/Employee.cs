using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class Employee
    {
        //Properties
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public float Salary { get; set; }

        //Constructor to initialize employee Details
        public Employee(int empId, string empName, float salary)
        {
            EmpId = empId;
            EmpName = empName;
            Salary = salary;
        }
    }
    public class PartTimeEmployee : Employee
    {
        //Property for additional wages
        public float Wages { get; set; }

        //Constructor to initialize all employee Details, including wages
        public PartTimeEmployee(int empId, string empName, float salary, float wages) : base(empId, empName, salary)
        {
            Wages = wages;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Asking user to enter employee details
            Console.WriteLine("Enter Employee ID:");
            int empid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name:");
            string empname = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary:");
            float salary = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Wages:");
            float wages = float.Parse(Console.ReadLine());

            // Create an object with user-provided details
            PartTimeEmployee p = new PartTimeEmployee(empid, empname, salary, wages);

            // Display the employee details to the user
            Console.WriteLine("\nEmployee Details are:");
            Console.WriteLine("Employee ID: " + p.EmpId);
            Console.WriteLine("Employee Name: " + p.EmpName);
            Console.WriteLine("Employee Salary: " + p.Salary);
            Console.WriteLine("Employee Wages: " + p.Wages);
            Console.ReadLine();
        }
    }
}
