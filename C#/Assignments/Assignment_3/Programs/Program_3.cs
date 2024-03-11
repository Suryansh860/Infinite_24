using System.Security.Policy;
using System;

public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}

// Bank account class
public class BankAccount
{
    private decimal balance;

    // Method to deposit money into the account
    public void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited: {amount}");
    }

    // Method to withdraw money from the account
    public void Withdraw(decimal amount)
    {
        if (amount > balance)
        {
            throw new InsufficientBalanceException("Insufficient balance to withdraw");
        }
        balance -= amount;
        Console.WriteLine($"Withdrawn: {amount}");
    }

    // Method to check balance
    public void CheckBalance()
    {
        Console.WriteLine($"Current Balance: {balance}");
        Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();

        try
        {
            Console.Write("Enter deposit amount: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            account.Deposit(depositAmount);

            Console.Write("Enter withdrawal amount: ");
            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
            account.Withdraw(withdrawAmount);

            account.CheckBalance();
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter a valid amount.");
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unhandled exception: {ex.Message}");
            
        }
    }
}
