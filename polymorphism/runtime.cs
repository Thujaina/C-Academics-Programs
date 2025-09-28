using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication4
{
    class EmailNotification
    {
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

        public virtual void Send()
        {
            Console.WriteLine("Sending a generic email...");
        }
    }
    // Derived class 1
    class WelcomeEmail : EmailNotification
    {
        public override void Send()
        {
            Console.WriteLine(" Welcome Email");
            Console.WriteLine("To: " + Recipient);
            Console.WriteLine("Subject: " + Subject);
            Console.WriteLine("Message: " + Message);
        }
    }
    // Derived class 2
    class PasswordResetEmail : EmailNotification
    {
        public override void Send()
        {
            Console.WriteLine("Password Reset Email");
            Console.WriteLine("To: " + Recipient);
            Console.WriteLine("Subject: " + Subject);
            Console.WriteLine("Message: " + Message);
        }
    }
    class PromotionEmail : EmailNotification  // Derived class 3
    {
        public override void Send()
        {
            Console.WriteLine("Promotion Email");
            Console.WriteLine("To: " + Recipient);
            Console.WriteLine("Subject: " + Subject);
            Console.WriteLine("Message: " + Message);
        }
    }
   class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose Email Type:");
            Console.WriteLine("1. Welcome Email");
            Console.WriteLine("2. Password Reset Email");
            Console.WriteLine("3. Promotion Email");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            EmailNotification email;
            switch (choice)
            {
                case 1:
                    email = new WelcomeEmail();
                    break;
                case 2:
                    email = new PasswordResetEmail();
                    break;
                case 3:
                    email = new PromotionEmail();
                    break;
                default:
                    email = new EmailNotification();
                    break;
            }
           Console.Write("Enter recipient email: ");
            email.Recipient = Console.ReadLine();
            Console.Write("Enter subject: ");
            email.Subject = Console.ReadLine();
            Console.Write("Enter message: ");
            email.Message = Console.ReadLine();
            Console.WriteLine("\n--- Sending Email ---");
            email.Send();
            Console.WriteLine("Email sent successfully on " + DateTime.Now);
            Console.WriteLine("Server: smtp.mailserver.com");
            Console.WriteLine("Security: TLS Encryption");
            Console.WriteLine("Tracking ID: MSG" + new Random().Next(1000, 9999));
            Console.WriteLine("Operation Completed");
        }
    }
}
