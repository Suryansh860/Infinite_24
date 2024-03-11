using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1
{
    internal class Program
    {
        string first_Name;
        string last_Name;

        static void Display(string firstName,string lastName)
        {
            Console.WriteLine(firstName.ToUpper());
            Console.WriteLine(lastName.ToUpper());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Name :");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name :");
            string lastName = Console.ReadLine();

            Display(firstName,lastName);
            Console.Read();
        }
    }
}
