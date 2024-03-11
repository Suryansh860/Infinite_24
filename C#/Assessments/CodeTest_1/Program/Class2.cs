using System;

public class Class2
{
        public static void main(string[] args)
		{

        int num1, num2, num3;

        Console.WriteLine("Input the 1st num");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input the 2nd num");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input the 3rd num");
        num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.WriteLine("1st is largest");
            }
            else
            {
                Console.WriteLine("3rd is largest");
            }
        }
        else if (num2 > num3)
        {
            Console.WriteLine("2nd is Largest");
        }
        else
        {
            Console.WriteLine("3rd is Largest");
        }
	}
}
