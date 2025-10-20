
SOURCECODE:
using System;
namespace DailyRoutineUserInput
{
    class Program
    {
        // Step 1: Declare delegate
        delegate void RoutineTask();
       // Step 2: Define task methods
        static void WakeUp() { Console.WriteLine("Wake Up"); }
        static void Exercise() { Console.WriteLine("Exercise"); }
        static void Breakfast() { Console.WriteLine("Breakfast"); }
        static void Study() { Console.WriteLine("Study"); }
        static void Lunch() { Console.WriteLine("Lunch"); }
        static void Relax() { Console.WriteLine("Relax"); }
        static void Sleep() { Console.WriteLine("Sleep"); }
        static void Main()
        {
            RoutineTask myRoutine = null;
            Console.WriteLine("--- Daily Routine Setup ---");
            Console.WriteLine("Select tasks to add to your routine (enter numbers, 0 to finish):");     
            Console.WriteLine("\n1. Wake Up");
            Console.WriteLine("2. Exercise");
            Console.WriteLine("3. Breakfast");
            Console.WriteLine("4. Study");
            Console.WriteLine("5. Lunch");
            Console.WriteLine("6. Relax");
            Console.WriteLine("7. Sleep");
            Console.WriteLine("0. Done\n");
            int choice = -1;
            do
            {
                Console.Write("Enter your choice: ");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }
                    switch (choice)
                {
                    case 1: myRoutine += WakeUp; break;
                    case 2: myRoutine += Exercise; break;
                    case 3: myRoutine += Breakfast; break;
                    case 4: myRoutine += Study; break;
                    case 5: myRoutine += Lunch; break;
                    case 6: myRoutine += Relax; break;
                    case 7: myRoutine += Sleep; break;
                    case 0: break;
                    default: Console.WriteLine("Invalid choice. Try again."); break;
                }
            } 
           while (choice != 0);
           Console.WriteLine("\nYour Daily Routine:");
            if (myRoutine != null)
                myRoutine();
            else
                Console.WriteLine("No tasks selected!");
        }
    }
}






