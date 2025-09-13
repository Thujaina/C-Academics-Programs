using System;
class BankInterest
{
    // Define bank account types as enum
    enum AccountType { Savings = 1, Current, FixedDeposit, RecurringDeposit, NRIAccount }
    static void Main()
    {
        // Arrays for account names and interest rates indexed by enum value
        string[] accNames = { "", "Savings", "Current", "FixedDeposit", "RecurringDeposit", "NRIAccount" };
        double[] rates = { 0, 0.04, 0.0, 0.06, 0.05, 0.07 };
        Console.WriteLine("=== Bank Interest Calculator ===");
        Console.Write("Enter Customer Name: "); 
        string name = Console.ReadLine();
        Console.Write("Enter Deposit Amount: "); 
        double amount = double.Parse(Console.ReadLine());
        while (true)
        {
            // Display options to user
            Console.WriteLine("\nSelect Account Type (or 0 to Exit):");
            Console.WriteLine("1. Savings (4%)\n2. Current (0%)\n3. Fixed Deposit (6%)\n4. Recurring Deposit (5%)\n5. NRI Account (7%)\n0. Exit");
            if (int.TryParse(Console.ReadLine(), out int c) && c >= 0 && c <= 5)
            {
                if (c == 0) break; // Exit loop if user chooses 0
                AccountType acc = (AccountType)c; // Cast int to enum for clarity
                double interest = amount * rates[c]; // Calculate interest using selected rate
                Console.WriteLine($"\n👤 Customer: {name}\n🏦 Account Type: {acc}\n💰 Deposit: {amount:C}\n📈 Annual Interest: {interest:C}”); // Show result
            }
            else 
                Console.WriteLine("❌ Invalid choice! Please select 1–5 or 0 to exit.");
        }
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
