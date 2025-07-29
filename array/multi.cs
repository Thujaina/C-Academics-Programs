using System;

class Program
{
    static void Main()
    {
        // 2D array to store marks of 3 students in 4 subjects
        int[,] marks = new int[3, 4];

        // Input: Enter marks for each student
        for (int student = 0; student < 3; student++)
        {
            Console.WriteLine($"\nEnter marks for Student {student + 1}:");

            for (int subject = 0; subject < 4; subject++)
            {
                Console.Write($"  Subject {subject + 1}: ");
                marks[student, subject] = int.Parse(Console.ReadLine());
            }
        }

        // Output: Display total marks for each student
        for (int student = 0; student < 3; student++)
        {
            int total = 0;

            for (int subject = 0; subject < 4; subject++)
            {
                total += marks[student, subject];
            }

            Console.WriteLine($"\nTotal marks for Student {student + 1}: {total}");
        }
    }
}
