using System;
using System.Collections.Generic;

class DoctorAppointment
{
    static void Main()
    {
        Console.WriteLine("Doctor Appointment System Started...\n");

        try
        {
            // 1. DivideByZeroException (calculate average patients per doctor)
            int patients = 20, doctors = 0;
            int avg = patients / doctors;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Exception 1: Cannot divide patients by zero doctors!");
            Console.WriteLine("Reason: We need at least 1 doctor to assign patients.\n");
        }

        try
        {
            // 2. NullReferenceException (patient record missing)
            string patientName = null;
            Console.WriteLine("Patient Name: " + patientName.ToUpper());
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Exception 2: Patient record not found!");
            Console.WriteLine("Reason: Tried accessing a patient name that is missing.\n");
        }

        try
        {
            // 3. IndexOutOfRangeException (wrong appointment slot)
            string[] slots = { "10 AM", "11 AM", "12 PM" };
            Console.WriteLine("Selected slot: " + slots[5]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Exception 3: Invalid appointment slot selected!");
            Console.WriteLine("Reason: Slot index is out of range. Please choose a valid time.\n");
        }

        try
        {
            // 4. FormatException (entering wrong age format)
            string input = "twenty";   // Wrong input
            int age = int.Parse(input);
        }
        catch (FormatException)
        {
            Console.WriteLine("Exception 4: Age must be entered in numbers!");
            Console.WriteLine("Reason: Entered value was not a valid integer.\n");
        }

        try
        {
            // 5. KeyNotFoundException (search doctor by ID)
            Dictionary<int, string> doctors = new Dictionary<int, string>()
            {
                {1, "Dr. Kumar"},
                {2, "Dr. Priya"}
            };

            Console.WriteLine("Doctor found: " + doctors[5]); // invalid key
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine("Exception 5: Doctor ID not found in records!");
            Console.WriteLine("Reason: No doctor exists with the given ID.\n");
        }
        finally
        {
            Console.WriteLine("Doctor Appointment System execution finished with exception handling.");
        }
    }
}