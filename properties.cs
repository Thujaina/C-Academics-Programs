using System;

class Client
{
    // Properties
    public string Name;
    public double Latitude;
    public double Longitude;

    // Constructor
    public Client(string name, double lat, double lon)
    {
        Name = name;
        Latitude = lat;
        Longitude = lon;
    }

    // Method to display client info
    public void Display()
    {
        Console.WriteLine("{0,-15} {1,-15} {2,-15}", Name, Latitude, Longitude);
    }
}

class Program
{
    // Haversine formula to calculate distance
    static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
    {
        double R = 6371; // Radius of Earth in km
        double dLat = (lat2 - lat1) * Math.PI / 180.0;
        double dLon = (lon2 - lon1) * Math.PI / 180.0;

        lat1 = lat1 * Math.PI / 180.0;
        lat2 = lat2 * Math.PI / 180.0;

        double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                   Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);
        double c = 2 * Math.Asin(Math.Sqrt(a));

        return R * c;
    }

    static void Main()
    {
        // Create 2 client objects
        Console.WriteLine("Enter details for client 1:");
        Console.Write("Name: ");
        string name1 = Console.ReadLine();
        Console.Write("Latitude: ");
        double lat1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Longitude: ");
        double lon1 = Convert.ToDouble(Console.ReadLine());
        Client client1 = new Client(name1, lat1, lon1);

        Console.WriteLine("\nEnter details for client 2:");
        Console.Write("Name: ");
        string name2 = Console.ReadLine();
        Console.Write("Latitude: ");
        double lat2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Longitude: ");
        double lon2 = Convert.ToDouble(Console.ReadLine());
        Client client2 = new Client(name2, lat2, lon2);

        // Display client info
        Console.WriteLine("\n--- Client Locations ---");
        Console.WriteLine("{0,-15} {1,-15} {2,-15}", "Name", "Latitude", "Longitude");
        client1.Display();
        client2.Display();

        // Calculate and display distance
        double distance = CalculateDistance(client1.Latitude, client1.Longitude,
                                            client2.Latitude, client2.Longitude);
        Console.WriteLine("\nDistance between {0} and {1}: {2:F2} km", client1.Name, client2.Name, distance);

        Console.ReadLine();
    }
}