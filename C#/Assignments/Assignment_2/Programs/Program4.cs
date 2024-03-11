using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    internal class Customer
        {
            public string CustomerId { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Phone { get; set; }
            public string City { get; set; }

            // Constructor with no arguments
            public Customer()
            {
            }

            // Constructor with all information
            public Customer(string customerId, string name, int age, string phone, string city)
            {
                CustomerId = customerId;
                Name = name;
                Age = age;
                Phone = phone;
                City = city;
            }

            public static void DisplayCustomer(string customerId, string name, int age, string phone, string city)
            {
                Console.WriteLine($"Customer ID: {customerId}");
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Phone: {phone}");
                Console.WriteLine($"City: {city}");
            }

            // Destructor
            ~Customer()
            {
            }
        }

        class Program
        {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter CustomerId:");
            string customerId = (Console.ReadLine());

            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter PhoneNumber:");
            string phone = (Console.ReadLine());

            Console.WriteLine("Enter CityName:");
            string city = Console.ReadLine();

            Customer.DisplayCustomer( customerId,  name,  age,  phone , city);
            Console.ReadLine();
            }
        }
    }
