using System;

class City //base class
{
    protected string cityName;
    protected int population;

    public City(string name, int pop)
    {
        cityName = name; population = pop;
    }
}

class Building : City //derived class1
{
    protected string buildingName, buildingType;
    protected int units;

    public Building(string city, int pop, string bName, string bType, int units)
        : base(city, pop)
    {
        buildingName = bName; buildingType = bType; this.units = units;
    }
}

class Consumption : Building //derived class2 from derived class1 
{
    private double usagePerUnit; // kWh
    private double rate; // per kWh

    public Consumption(string city, int pop, string bName, string bType, int units, double usage, double rate)
        : base(city, pop, bName, bType, units)
    {
        this.usagePerUnit = usage; this.rate = rate;
    }

    public void ShowReport()
    {
        double totalUsage = units * usagePerUnit;
        double totalBill = totalUsage * rate;
        string efficiency = usagePerUnit < 200 ? "Efficient" : "High Consumption";

        Console.WriteLine("\n======= Smart City Power Consumption Report =======");
        Console.WriteLine($"City: {cityName}  |  Population: {population}");
        Console.WriteLine($"Building: {buildingName} ({buildingType})");
        Console.WriteLine($"Units: {units}, Avg Usage/Unit: {usagePerUnit} kWh");
        Console.WriteLine($"Total Usage: {totalUsage} kWh");
        Console.WriteLine($"Rate: ₹{rate}/kWh   -->   Total Bill: ₹{totalBill}");
        Console.WriteLine($"Efficiency Status: {efficiency}");
        Console.WriteLine("===================================================");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter City Name: "); string city = Console.ReadLine();
        Console.Write("Enter Population: "); int pop = int.Parse(Console.ReadLine());
        Console.Write("Enter Building Name: "); string bName = Console.ReadLine();
        Console.Write("Enter Building Type (Residential/Commercial): "); string bType = Console.ReadLine();
        Console.Write("Enter Number of Units: "); int units = int.Parse(Console.ReadLine());
        Console.Write("Enter Average Usage per Unit (kWh): "); double usage = double.Parse(Console.ReadLine());
        Console.Write("Enter Rate per kWh (₹): "); double rate = double.Parse(Console.ReadLine());

        Consumption c = new Consumption(city, pop, bName, bType, units, usage, rate);
        c.ShowReport();
    }
}
