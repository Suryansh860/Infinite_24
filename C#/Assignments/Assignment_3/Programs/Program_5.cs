using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Program_1
{
    internal class Doctor
    {
        // Private members
        private int regnNo;
        private string name;
        private double feesCharged;

        // Properties
        public int RegnNo
        {
            get { return regnNo; }
            set { regnNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double FeesCharged
        {
            get { return feesCharged; }
            set { feesCharged = value; }
        }

        // Method to set the values....
        public void SetValues(int regnNo, string name, double feesCharged)
        {
            RegnNo = regnNo;
            Name = name;
            FeesCharged = feesCharged;
        }

        // Method to display the values....
        public void Display()
        {
            Console.WriteLine("Reg. Number: " + RegnNo);
            Console.WriteLine("Doctor Name: " + Name);
            Console.WriteLine("Fees Charged: " + FeesCharged);
        }
        static void Main (string[] args)
            
        {
            Doctor doctor = new Doctor();
            Console.WriteLine("Enter the Patient Reg.Number:");
            int RegnNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Doctor Name:");
            string Name = (Console.ReadLine());
            Console.WriteLine("Enter Fees Amount:");
            double FeesCharged = double.Parse(Console.ReadLine());

            doctor.SetValues(RegnNo,  Name,  FeesCharged);
            doctor.Display();
            Console.ReadLine();
        }
    }
}

