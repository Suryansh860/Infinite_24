using Assignment_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Accounts
    {
        public int AccountNo;
        public string CustomerName;
        public string AccountType;
        public string TransactionType;
        public double Amount;
        public double Balance;

        // Constructor
        public Accounts(int AccountNO, string CustomerName, string AccountType)
        {
            this.AccountNo = AccountNO;
            this.CustomerName = CustomerName;
            this.AccountType = AccountType;
        }

        
        public void show()
            {
                Console.WriteLine("Enter the Account No:");
                AccountNo = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Customer Name:");
                CustomerName = (Console.ReadLine());

                Console.WriteLine("Enter Account Type: ");
                AccountType = (Console.ReadLine());

                Console.WriteLine("Enter Transaction Type (d > deposit / w > withdrawal):");
                TransactionType = (Console.ReadLine());

                Console.WriteLine("Enter the Amount:");
                Amount = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Balance:");
                Balance = double.Parse(Console.ReadLine());

            }

            void Credit(double Amount)
            {
                Balance = Balance + Amount;
            }

            void Debit(double Amount)
            {
                if (Amount <= Balance)
                {
                    Balance = Balance - Amount;
                }
                else
                {
                    Console.WriteLine("Insufficient balance for withdrawal:");
                }
            }

            void updateBalance()
            {
                if (TransactionType == "d")
                {
                    Credit(Amount);
                }
                else if (TransactionType == "w")
                {
                    Debit(Amount);
                }
                else
                {
                    Console.WriteLine("Invalid transaction type.");
                }
            }

            void showData()
            {
                Console.WriteLine("Account No: {0} , Customer Name: {1} , Account type: {2} , Transaction Type: {3} , Amount: {4} , Balance: {5} ", AccountNo, CustomerName, AccountType, TransactionType, Amount, Balance);
            }
            public Accounts()
            {
        }

        static void Main(string[] args)
            {
  
            Accounts acc = new Accounts();
            acc.show();
            acc.updateBalance();
            acc.showData();
            Console.ReadLine();

        }
    }
}
