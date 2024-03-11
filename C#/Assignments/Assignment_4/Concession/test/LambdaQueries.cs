using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class LambdaQueries
    {
        static void LambdaQuery_1()
        {
            //taking user input which is seperated by commas...
            Console.WriteLine("Enter numbers by seperating them commas:");
            string s = Console.ReadLine();

            //Split the input string by commas and converting each part into an Integer....
            int[] numbers = s.Split(',').Select(int.Parse).ToArray();

            //Selecting the square of each number and filtering those numbers which are greater than 20
            var result = numbers.Select(n => n * n).Where(square => square > 20);

            //Displaying the Result or Numbers (which are greater than 20)

            Console.WriteLine("Square greater than 20: ");
            foreach (var square in result)
            {
                Console.WriteLine(square);
            }
            Console.ReadLine();
        }
        static void LambdaQuery_2()
        {
            {
                //Taking user input words which is seperated by commas....
                Console.WriteLine("Enter the words seperated by commas:");
                string s = Console.ReadLine();

                //Spliting the input string into an array of words....
                string[] words = s.Split(',');

                //Query to filtering the words which is starting with 'a' and ending with 'm'.....
                var Result = words.Where(word => word.Trim().StartsWith("a", StringComparison.OrdinalIgnoreCase) && word.Trim().EndsWith("m", StringComparison.OrdinalIgnoreCase));

                //Printing the Output...

                Console.WriteLine("Words starting with 'a' and ending with 'm':");
                foreach (var word in Result)
                {
                    Console.WriteLine(word.Trim());
                }
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            LambdaQuery_1();
            LambdaQuery_2();
        }
    }
}
