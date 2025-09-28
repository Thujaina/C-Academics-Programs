using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication19
{
    class BillGenerator
    {
        // Method to calculate bill for single item (price only, no quantity)
        public double CalculateBill(double price)
        {
            return price;
        }
        // Method to calculate bill for item with quantity
        public double CalculateBill(double price, int quantity)
        {
            return price * quantity;
        }
        // Method to calculate bill with discount
        public double CalculateBill(double price, int quantity, double discountPercent)
        {
            double total = price * quantity;
            double discount = (discountPercent / 100) * total;
            return total - discount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BillGenerator bill = new BillGenerator();
            Console.WriteLine("===== BILL GENERATOR =====");
            Console.Write("Enter Item Price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());
            Console.Write("Do you have discount? (yes/no): ");
            string choice = Console.ReadLine().ToLower();
            double subtotal = price * qty;
            double discount = 0;
            double total;
            if (choice == "yes")
            {
                Console.Write("Enter Discount Percentage: ");
                discount = Convert.ToDouble(Console.ReadLine());
                total = bill.CalculateBill(price, qty, discount);
            }
            else
            {
                total = bill.CalculateBill(price, qty);
            }
            double tax = 0.05 * total;   // 5% GST
            double finalAmount = total + tax;
            Console.WriteLine("\n===== FINAL BILL =====");
            Console.WriteLine("Item Price       : " + price);
            Console.WriteLine("Quantity         : " + qty);
            Console.WriteLine("Subtotal         : " + subtotal);
            Console.WriteLine("Discount Applied : " + discount + "%");
            Console.WriteLine("Amount after Discount : " + total);
            Console.WriteLine("GST (5%)         : " + tax);
            Console.WriteLine("Final Amount     : " + finalAmount);
            Console.WriteLine("=======================");
            Console.WriteLine("Thank you for shopping with us!");
            Console.WriteLine("Visit Again!");
        }
    }
}
