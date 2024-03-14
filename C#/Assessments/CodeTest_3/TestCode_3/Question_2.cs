using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
    //Defining a delegate for representing the calculator functinalities.....
    public delegate int CalculatorDelegate(int a,int b);
    class Question_2
    {

        static void Main(string[] args)
        {

            //Taking user input
            Console.WriteLine("Enter the Numbers:--------------------------");
            Console.WriteLine("Enter Number1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number2:");
            int num2 = int.Parse(Console.ReadLine());

            //To performing addition, subtraction and multiplication using delegates
            CalculatorDelegate addition = Add;
            CalculatorDelegate subtraction = Subtract;
            CalculatorDelegate multiplication = Multiply;

            //Displaying the results
            Console.WriteLine($"Result of addition of two numbers are: {addition(num1,num2)}");
            Console.WriteLine($"Result of subtraction of two numbers are: {subtraction(num1, num2)}");
            Console.WriteLine($"Result of multiplication of two numbers are: {multiplication(num1,num2)}");
            Console.ReadLine();
        }
        //Method to perform addition
        static int Add(int a, int b)
        {
            return a + b;
        }
        //Method to perform subtraction
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        //Method to perform multiplication
        static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
