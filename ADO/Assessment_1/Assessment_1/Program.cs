using Assessment_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.netAssesment
{
    class Program
    {
        static DataClasses1DataContext dc = new DataClasses1DataContext();  
        static void Main(string[] args)
        {
            InsertEmp_Det();
            //ShowEmp_Det();

            Console.Read();
        }
        public static void InsertEmp_Det()
        {
            
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Salary: ");
            int sal = int.Parse(Console.ReadLine());
            Console.Write("Enter Employee Type: ");
            char emptype = char.Parse(Console.ReadLine());

           
            dc.Add_Emp_Details(name, sal, emptype);
            Console.WriteLine("Details Added Successfully......");
        }

        public static void ShowEmp_Det()
        {
            var emp = dc.Employee_Details.ToList();
            foreach (var x in emp)
            {
                Console.WriteLine($"Employee No: {x.Emp_No}\n Employee Name: {x.Emp_Name}\n Salary: {x.Emp_Sal}\n Employee Type: {x.Emp_Type}");
            }
        }
    }
}