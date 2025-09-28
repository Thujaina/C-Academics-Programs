using System;
using System.Collections.Generic;

class Client
{
    public string Name { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public Client(string name, double lat, double lon)
    {
        Name = name;
        Latitude = lat;
        Longitude = lon;
    }
}

class Program
{
    // Method to calculate distance (Haversine Formula)
    static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
    {
        double R = 6371; // Radius of Earth in km
        double dLat = (lat2 - lat1) * Math.PI / 180.0;
        double dLon = (lon2 - lon1) * Math.PI / 180.0;

        // Convert to radians
        lat1 = lat1 * Math.PI / 180.0;
        lat2 = lat2 * Math.PI / 180.0;

        double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                   Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);
        double c = 2 * Math.Asin(Math.Sqrt(a));

        return R * c; // Distance in km
    }

    static void Main()
    {
        List<Client> clients = new List<Client>();

        Console.Write("Enter number of clients: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Input client details
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nEnter details for client " + (i + 1));

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Latitude: ");
            double lat = Convert.ToDouble(Console.ReadLine());

            Console.Write("Longitude: ");
            double lon = Convert.ToDouble(Console.ReadLine());

            clients.Add(new Client(name, lat, lon));
        }

        // Display clients in a chart
        Console.WriteLine("\n--- Client Locations ---");
        Console.WriteLine("{0,-15} {1,-15} {2,-15}", "Name", "Latitude", "Longitude");
        foreach (Client c in clients)
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-15}", c.Name, c.Latitude, c.Longitude);
        }

        // Calculate distance between first two clients if at least 2 are entered
        if (clients.Count >= 2)
        {
            double distance = CalculateDistance(clients[0].Latitude, clients[0].Longitude,
                                                clients[1].Latitude, clients[1].Longitude);
            Console.WriteLine("\nDistance between {0} and {1}: {2:F2} km",
                clients[0].Name, clients[1].Name, distance);
        }
        else
        {
            Console.WriteLine("\nNot enough clients to calculate distance.");
        }
    }
}
