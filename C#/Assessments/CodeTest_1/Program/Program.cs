using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
          public static string test(string str, int i)
        {
            return str.Remove(i, 1);
        } 
        static void Main(string[] args)
        {
            Console.WriteLine(test("Python", 1));
            Console.WriteLine(test("Python", 0));
            Console.WriteLine(test("Python", 4));
            Console.ReadLine();

        }
        
    }
}


