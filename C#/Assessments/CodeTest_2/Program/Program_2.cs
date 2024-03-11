using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Test2
{
    public class Product
    {
        public int ProductId;
        public string ProductName;
        public double Price;
        class Program
        {

            static void Main(string[] args)
            {
                Product[] products = new Product[10];

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Enter details for product {i + 1}:");
                    Console.Write("Enter the Product ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the Product Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Price of the Product: ");
                    double price = Convert.ToDouble(Console.ReadLine());

                    products[i] = new Product { ProductId = id, ProductName = name, Price = price };
                }

                Array.Sort(products, (x, y) => x.Price.CompareTo(y.Price));

                Console.WriteLine("\nSorted Products based on price:");
                foreach (var product in products)
                {
                    Console.WriteLine($"Product ID: {product.ProductId}, Product Name: {product.ProductName}, Price: {product.Price}");
                    Console.ReadLine();
                }

            }

        }

    }
}
