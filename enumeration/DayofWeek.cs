using System;

enum DayOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number (0-6) to get the day of the week:");
        int input = Convert.ToInt32(Console.ReadLine());

        if (input >= 0 && input <= 6)
        {
            DayOfWeek day = (DayOfWeek)input;
            Console.WriteLine($"Day {input} is {day}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 6.");
        }
    }
}
