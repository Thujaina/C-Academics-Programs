using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace ConsoleApplication6
{
    class Resume
    {
        public string Name, Email, Phone, Skill;

        public void CollectInput()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Email: ");
            Email = Console.ReadLine();
            Console.Write("Enter Phone: ");
            Phone = Console.ReadLine();
            Console.Write("Enter Skill: ");
            Skill = Console.ReadLine();

            Console.WriteLine("\nUser input collected successfully!");
        }

        public void FormatResume()
        {
            Thread.Sleep(1000);
            Console.WriteLine("\nFormatting Resume...");
            Console.WriteLine("==============================");
            Console.WriteLine("            RESUME");
            Console.WriteLine("==============================");
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Phone: " + Phone);
            Console.WriteLine("Skill: " + Skill);
            Console.WriteLine("==============================");
        }

        public void SaveResume()
        {
            Thread.Sleep(800);
            Console.WriteLine("\n Resume saved successfully at: C:/Resumes/" + Name + ".txt");
        }
    }

    class Program
    {
        static void Main()
        {
            Resume resume = new Resume();

            Thread t1 = new Thread(resume.CollectInput);
            Thread t2 = new Thread(resume.FormatResume);
            Thread t3 = new Thread(resume.SaveResume);

            t1.Start(); t1.Join();   // Collect input
            t2.Start(); t2.Join();   // Format resume
            t3.Start(); t3.Join();   // Save resume

            Console.WriteLine("\nAll operations completed successfully!");
        }
    }
}
