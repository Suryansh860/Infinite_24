using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1
{
    internal class Scholarship
    {
        public double Merit(double marks, double fees)
        {
            double scholarshipAmount = 0;

            if (marks >= 70 && marks <= 80)
            {
                scholarshipAmount = 0.2 * fees;
            }
            else if (marks > 80 && marks <= 90)
            {
                scholarshipAmount = 0.3 * fees;
            }
            else if (marks > 90)
            {
                scholarshipAmount = 0.5 * fees;
            }

            return scholarshipAmount;
        }
        static void Main()
        {
            Console.WriteLine("Enter the Marks:");
            double marks = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Fees");
            double fees = double.Parse(Console.ReadLine());

            Scholarship sc = new Scholarship();
            double Result = sc.Merit( marks, fees);

            Console.WriteLine(" scholarship amt: " +  Result);
            Console.ReadLine();
        }

    }
}
