using System;
using System.Reflection.Metadata.Ecma335;
namespace Dotnet
{
    // class and objects creation
    public class BankAccount
    {
        public string HolderName {get; set;};
        private float balance; // Usage of encapsulation

        public void Deposit(float amount)
        {
            balance += amount;
        }
        public void Withdraw(float amount)
        {
            if (amount <= balance)
                balance -= amount;
            else
                Console.WriteLine("Insufficient Balance");
        }
        public float Getbalance()
        {
            return balance; 
        }

        public void Details()
        {
            Console.WriteLine($"Name: {HolderName}, Balance: {balance}");
        }

    }
    public class Dotnet
    {
        static void Main(string[] args)
        {
            // Method Creation
            BankAccount obj = new BankAccount();
            obj.HolderName = "Jaanu";
            obj.Deposit(10000.00F);
            obj.Withdraw(10000.00F);
            obj.Details();

            BankAccount obj2 = new BankAccount() { HolderName = "Radha" }; // balance = 20000.00F };
            obj2.Deposit(20000.00F);
            obj2.Withdraw(10000.00F);
            obj2.Details();

            // BankAccount obj3 = new BankAccount() { HolderName = "Jahanavi" };
            // obj3.Deposit(25000.00F);
            // obj3.Details();

        }
    }
}
    
