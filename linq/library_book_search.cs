//SOURCE CODE:
using System;
using System.Linq;
class Program
{
static void Main()
{
// Array of books
string[] books = {
"C# Basics for Beginners",
"Mastering Python",
"Introduction to AI",
"Data Science with C#",
"Advanced Java Programming",
"AI for Everyone",
"Machine Learning Made Easy"
};
Console.WriteLine("📚 Welcome to the Book Library");
Console.Write("Enter a keyword to search: ");
string keyword = Console.ReadLine();
// LINQ query to filter books
var results = books
.Where(b => b.ToLower().Contains(keyword.ToLower()))
.OrderBy(b => b);
Console.WriteLine("\n🔎 Search Results:");
if (results.Any())
{
foreach (var book in results)
{
Console.WriteLine("- " + book);
}
}
else
{
Console.WriteLine("No books found matching your keyword.");
}
// Keep console open
Console.WriteLine("\nPress Enter to exit...");
Console.ReadLine();
}
}
OUTPUT 1:
