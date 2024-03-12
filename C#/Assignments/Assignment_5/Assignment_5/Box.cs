using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Assignment_5
{
    internal class Box
    {
        //Properties to store the length and breadth of the box
        public int Length { get; set; }
        public int Breadth { get; set; }

        //Constructor to initialize the length and breadth of the box
        public Box(int length, int breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        //Function to add two box objects and storing the result in the 3rd box object
        public static Box Add(Box box1, Box box2)
        {
            int length = box1.Length + box2.Length;
            int breadth = box1.Breadth + box2.Breadth;
            return new Box(length, breadth);
        }
    }
    //Creating test class for the execution of the above....
    class Test
    {
        static void Main(string[] args)
        {
            //Taking diamensions(length and breadth) from the user as input

            Console.WriteLine("Enter diamensions for Box 1:");
            Console.WriteLine("Enter the length of Box1: ");
            int length_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the breadth of Box1: ");
            int breadth_1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter diamensions for Box 2:");
            Console.WriteLine("Enter the length of Box2: ");
            int length_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the breadth of Box2: ");
            int breadth_2 = int.Parse(Console.ReadLine());

            //Creating objects of two boxes....
            Box b1 = new Box(length_1, breadth_1);
            Box b2 = new Box(length_2, breadth_2);

            //Adding the two box objects and storing the result in the 3rd box object...
            Box b3 = Box.Add(b1, b2);

            //Display the diamensions of the third box....
            Console.WriteLine($"Length of Box_3 is: {b3.Length}and the Breadth of the Box_3 is: {b3.Breadth}");
            Console.ReadLine();
        }
    }

}
