using System;

class Program
{
    static void Main()
    {
        // Create and initialize an integer array
        int[] numbers = new int[] { 10, 20, 30, 40, 50 };

        Console.WriteLine("Array Elements:");

        // Display each element using a for loop
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Element at index " + i + ": " + numbers[i]);
        }
    }
}
