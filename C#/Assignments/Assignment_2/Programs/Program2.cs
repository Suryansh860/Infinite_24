using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class Student
    {
        public int RollNo;
        public string Name;
        public string Class;
        public string Semester;
        public string Branch;
        public int[] Marks = new int[5];


        public Student(int rollNo, string name, string studentClass, string semester, string branch)
        {
            RollNo = rollNo;
            Name = name;
            Class = studentClass;
            Semester = semester;
            Branch = branch;
        }
            public void GetMarks()
            {
                Console.WriteLine("Enter marks of 5 subjects:");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"Subject {i + 1}: ");
                    Marks[i] = int.Parse(Console.ReadLine());
                }
            }
            public double calculateAverage()
            {
                double sum = 0;
                foreach (int mark in Marks)
                {
                    sum += mark;
                }
                return sum / 5;
            }


            public void Displayresult()
            {
                bool anySubjectFailed = false;
                foreach (int mark in Marks)
                {
                    if (mark < 35)
                    {
                        anySubjectFailed = true;
                    }
                }

                if (anySubjectFailed)
                {
                    Console.WriteLine("Result: Failed");
                }
                else
                {
                    double average = calculateAverage();
                    Console.WriteLine($"Average Marks: {average}");

                    if (average < 33)
                    {
                        Console.WriteLine("Result: Failed");
                    }
                    else
                    {
                        Console.WriteLine("Result: Passed");

                    }


                }
            }
            public void DisplayData()
            {
                Console.WriteLine($"Roll No: {RollNo}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Class: {Class}");
                Console.WriteLine($"Semester: {Semester}");
                Console.WriteLine($"Branch: {Branch}");
                Console.WriteLine("Marks:");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Subject {i + 1}: {Marks[i]}");
                }

            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Student student1 = new Student(1, "Suryansh Dwivedi", "B.tech", "5th", "CSE");
                student1.GetMarks(); 
                student1.Displayresult();
                student1.DisplayData(); 
                Console.ReadLine();
            }
        }
    }


