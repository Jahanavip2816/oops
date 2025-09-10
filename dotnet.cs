// using System;
// using System.Reflection.Metadata.Ecma335;
// namespace Dotnet
// {
//     public class BankAccount
//     {
//         public string HolderName;
//         private float balance;

//         public void Deposit(float amount)
//         {
//             balance += amount;
//         }
//         public void Withdraw(float amount)
//         {
//             if (amount <= balance)
//                 balance -= amount;
//             else
//                 Console.WriteLine("Insufficient Balance");
//         }
//         public float Getbalance()
//         {
//             return balance; 
//         }

//         public void Details()
//         {
//             Console.WriteLine($"Name: {HolderName}, Balance: {balance}");
//         }

//     }
//     public class Dotnet
//     {
//         static void Main(string[] args)
//         {

//             BankAccount obj = new BankAccount();
//             obj.HolderName = "Jaanu";
//             obj.Deposit(10000.00F);
//             obj.Withdraw(10000.00F);
//             obj.Details();

//             BankAccount obj2 = new BankAccount() { HolderName = "Radha" }; // balance = 20000.00F };
//             obj2.Deposit(20000.00F);
//             obj2.Withdraw(10000.00F);
//             obj2.Details();

//             // BankAccount obj3 = new BankAccount() { HolderName = "Jahanavi" };
//             // obj3.Deposit(25000.00F);
//             // obj3.Details();

//         }
//     }
// }

using System;

// -------------------- ABSTRACTION --------------------
abstract class BankAccount
{
<<<<<<< HEAD
    public string HolderName { get; set; }   // Common property
    private double balance;                  // Encapsulated field

    // Constructor
    public BankAccount(string holderName, double initialBalance)
    {
        HolderName = holderName;
        balance = initialBalance;
=======
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

>>>>>>> c051379d3c5b87d084dbc68c191386b4a8269ead
    }

    // Encapsulation: methods to safely access balance
    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"{HolderName} deposited {amount}. New Balance: {balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
<<<<<<< HEAD
            balance -= amount;
            Console.WriteLine($"{HolderName} withdrew {amount}. Remaining Balance: {balance}");
=======
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

>>>>>>> c051379d3c5b87d084dbc68c191386b4a8269ead
        }
        else
        {
            Console.WriteLine("Insufficient Balance!");
        }
    }

    public double GetBalance()
    {
        return balance;
    }

    // Abstraction: Must be implemented by derived classes
    public abstract void AccountType();
}

// -------------------- INHERITANCE --------------------
class SavingsAccount : BankAccount
{
    public SavingsAccount(string holderName, double initialBalance)
        : base(holderName, initialBalance) { }

    // ---------------- POLYMORPHISM (Overriding) ----------------
    public override void AccountType()
    {
        Console.WriteLine($"{HolderName} has a Savings Account.");
    }
}
<<<<<<< HEAD

class CurrentAccount : BankAccount
{
    public CurrentAccount(string holderName, double initialBalance)
        : base(holderName, initialBalance) { }

    public override void AccountType()
    {
        Console.WriteLine($"{HolderName} has a Current Account.");
    }
}

// -------------------- MAIN PROGRAM --------------------
class Program
{
    static void Main(string[] args)
    {
        // Create Savings Account
        BankAccount acc1 = new SavingsAccount("Jaanu", 10000);
        acc1.AccountType();             // Abstraction + Polymorphism
        acc1.Deposit(2000);             // Encapsulation
        acc1.Withdraw(5000);
        Console.WriteLine($"Final Balance: {acc1.GetBalance()}");
        Console.WriteLine();

        // Create Current Account
        BankAccount acc2 = new CurrentAccount("Radha", 20000);
        acc2.AccountType();
        acc2.Deposit(5000);
        acc2.Withdraw(30000);           // Shows insufficient balance
        Console.WriteLine($"Final Balance: {acc2.GetBalance()}");
    }
}

    
=======
    
>>>>>>> c051379d3c5b87d084dbc68c191386b4a8269ead
