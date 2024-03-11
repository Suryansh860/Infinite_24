using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
        internal class Saledetails
        {
           
            public int SalesNo;
            public int ProductNo;
            public double Price;
            public DateTime DateOfSale;
            public int Qty;
            public double TotalAmount;

            public Saledetails(int salesNo, int productNo, double price, DateTime dateOfSale, int qty)
            {
                SalesNo = salesNo;
                ProductNo = productNo;
                Price = price;
                DateOfSale = dateOfSale;
                Qty = qty;
                UpdateTotalAmount(); 
            }

            void UpdateTotalAmount()
            {
                TotalAmount = Qty * Price;
            }

            public void ShowData()
            {
                Console.WriteLine("Sales No: " + SalesNo);
                Console.WriteLine("Product No: " + ProductNo);
                Console.WriteLine("Price: " + Price);
                Console.WriteLine("Date of Sale: " + DateOfSale.ToShortDateString());
                Console.WriteLine("Quantity: " + Qty);
                Console.WriteLine("Total Amount: " + TotalAmount);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter Sales No:");
                int salesNo = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Product No:");
                int productNo = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Price:");
                double price = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Date of Sale (yyyy-MM-dd):");
                DateTime dateOfSale = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Enter Quantity:");
                int qty = int.Parse(Console.ReadLine());

                // Create an instance of Saledetails
                Saledetails sale = new Saledetails(salesNo, productNo, price, dateOfSale, qty);

               
                sale.ShowData();
                Console.ReadLine();
            }
        }

    }
