using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
    class Question_1
    {
        string fileLocation = "Example.txt";
        public static void WriteData()
        {
            FileStream f = new FileStream("Example.txt", FileMode.Append, FileAccess.Write);

            StreamWriter s = new StreamWriter(f);

            Console.WriteLine("Enter the String :");

            string str = Console.ReadLine();
            s.Write(str);
            s.Close();
            f.Close();
        }
    }
    class Program_Test
    {
        public static void Main(string[] args)
        {
            Question_1.WriteData();
            Console.ReadLine();
        }
    }
}