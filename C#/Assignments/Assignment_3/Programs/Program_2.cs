using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Program_1
{
    internal class Program_2
    {
        //method to count the no. of occurence of a letter in the string....
        static int CountOccurenceOfLetter(string Str, char Letter)
        {
            int count = 0;
            foreach (char c in Str)
            {
                if (c == Letter)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string Str = Console.ReadLine();

            Console.WriteLine("Enter the letter which you want to count:");
            char Letter = char.Parse(Console.ReadLine());

            int count = CountOccurenceOfLetter(Str, Letter);
            Console.WriteLine("The letter "+Letter+ " occurs " + count + " times in the string");
            Console.ReadLine();
        }
    }
}
