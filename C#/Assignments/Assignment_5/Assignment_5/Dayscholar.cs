using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    //Defining the interface
    interface IStudent
    {
        //Properties
        int StudentId { get; set; }
        string StudentName { get; set; }

        //Method to show student details
        void ShowDetails();
    }
    //Implimenting interface in the Dayscholar class
    public class Dayscholar : IStudent
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        //Implementing the method ShowDetails() which is created in interface
        public void ShowDetails()
        {
            Console.WriteLine("Details of DayScholars:");
            Console.WriteLine($"studentId: {StudentId} studentName: {StudentName}");
        }
    }
    //Implementing the interface in Resident class
    public class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public void ShowDetails()
        {
            Console.WriteLine("Details of Resient students are:");
            Console.WriteLine($"studentId: {StudentId} studentName: {StudentName}");
        }
    }
    class Program_Test
    {
        static void Main(string[] args)
        {
            //Taking user input for Dayscholar students
            Console.WriteLine("Enter Details of Dayscholar Students:");
            Dayscholar dayscholar = new Dayscholar();
            Console.WriteLine("Enter the Id of the Student:");
            dayscholar.StudentId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Name of the Student:");
            dayscholar.StudentName = Console.ReadLine();

            //Taking user input for Resident student
            Console.WriteLine("Enter Details of Resident Students:");
            Resident resident = new Resident();
            Console.WriteLine("Enter the Id of the Resident student:");
            resident.StudentId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Name of Resident Student:");
            resident.StudentName = Console.ReadLine();

            //Displaying the student details....
            Console.WriteLine("Student Details are:----------------------------------------------------");
            dayscholar.ShowDetails();
            resident.ShowDetails();
            Console.ReadLine();
            
        }
    }

}
