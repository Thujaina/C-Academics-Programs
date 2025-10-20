using System;

class Person //base class
{
    protected string name;
    protected int age;
    public Person(string name, int age)
    {
        this.name = name; this.age = age;
    }
}

class Patient : Person //derived class
{
    protected int patientId;
    protected string disease;

    public Patient(string name, int age, int patientId, string disease)
        : base(name, age)
    {
        this.patientId = patientId; this.disease = disease;
    }
}

interface IHealthCheck
{
    void ScanVitals();
}

interface IReport
{
    void GenerateReport();
}

class PatientHealth : Patient, IHealthCheck, IReport //derived class from 2 base classes and interface IHealthCheck
{
    private double temperature, bpSystolic, bpDiastolic, heartRate;
    private string status = "Normal";

    public PatientHealth(string name, int age, int id, string disease,
                         double temp, double sys, double dia, double hr)
        : base(name, age, id, disease)
    {
        temperature = temp; bpSystolic = sys; bpDiastolic = dia; heartRate = hr;
    }

    public void ScanVitals()
    {
        if (temperature > 37.5) status = "Fever Detected";
        if (bpSystolic > 140 || bpDiastolic > 90) status = "High Blood Pressure";
        if (heartRate < 60 || heartRate > 100) status = "Abnormal Heart Rate";
    }

    public void GenerateReport()
    {
        Console.WriteLine("\n===== Patient Health Report =====");
        Console.WriteLine($"Patient ID   : {patientId}");
        Console.WriteLine($"Name         : {name}, Age: {age}");
        Console.WriteLine($"Disease      : {disease}");
        Console.WriteLine($"Temperature  : {temperature} °C");
        Console.WriteLine($"BP           : {bpSystolic}/{bpDiastolic} mmHg");
        Console.WriteLine($"Heart Rate   : {heartRate} bpm");
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Health Status: {status}");
        Console.WriteLine("Recommendation: Consult doctor & follow treatment.\n");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Patient Name: "); string name = Console.ReadLine();
        Console.Write("Enter Age: "); int age = int.Parse(Console.ReadLine());
        Console.Write("Enter Patient ID: "); int id = int.Parse(Console.ReadLine());
        Console.Write("Enter Disease: "); string dis = Console.ReadLine();

        Console.Write("Enter Temperature (°C): "); double temp = double.Parse(Console.ReadLine());
        Console.Write("Enter BP Systolic: "); double sys = double.Parse(Console.ReadLine());
        Console.Write("Enter BP Diastolic: "); double dia = double.Parse(Console.ReadLine());
        Console.Write("Enter Heart Rate (bpm): "); double hr = double.Parse(Console.ReadLine());

        PatientHealth p = new PatientHealth(name, age, id, dis, temp, sys, dia, hr);
        p.ScanVitals();
        p.GenerateReport();
    }
}
