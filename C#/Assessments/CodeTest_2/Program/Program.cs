//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace Code_Test2
//{
//    abstract class Student
//    {
//        public string Name { get; set; }
//        public int StudentId { get; set; }
//        public double Grade { get; set; }

//        public abstract bool IsPassed(double grade);

//    }
//    class Undergraduate : Student
//    {
//        public override bool IsPassed(double grade)
//        {
//            return grade > 70.0;
//        }
//    }

//    class Graduate : Student
//    {
//        public override bool IsPassed(double grade)
//        {
//            return grade > 80.0;
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the name for UnderGraduate:");
//            String underGraduateName = Console.ReadLine();
//            Console.WriteLine("Enter the StudentId");
//            int underGraduateId = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter the Grade:");
//            double grade = double.Parse(Console.ReadLine());

//            Undergraduate un = new Undergraduate();

//            Console.WriteLine("Enter the name for Graduate:");
//            String graduateName = Console.ReadLine();
//            Console.WriteLine("Enter the StudentId");
//            int graduateId = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter the Grade:");
//            double graduategrade = double.Parse(Console.ReadLine());

//            Graduate gr = new Graduate();


//            Console.WriteLine("Undergraduate student result: " + (un.IsPassed(grade) ? "Passed" : "Failed"));
//            Console.WriteLine("Graduate student result: " + (gr.IsPassed(grade) ? "Passed" : "Failed"));
//            Console.ReadLine();
//        }
//    }
//}
