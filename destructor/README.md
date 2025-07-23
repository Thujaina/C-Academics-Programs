# 📐 LineApplication in C#

This project is a simple C# console application that demonstrates the use of **constructor** and **destructor** in a class. It encapsulates the concept of object lifecycle in C# with basic functionality to set and get the length of a line.

---

## 📌 Features

- ✅ Default Constructor – prints a message when an object is created.
- ✅ Destructor – prints a message when an object is destroyed.
- ✅ Encapsulation using private fields and public methods.
- ✅ Simple getter and setter implementation.

---

## 🧾 Code Overview

```csharp
public Line()
{
    Console.WriteLine("Object is being created");
}

~Line()
{
    Console.WriteLine("Object is being deleted");
}

💡 Output Example

Object is being created
Length of line : 6
Object is being deleted

Note: Destructor messages may not appear immediately due to garbage collection behavior in C#.

🖥️ How to Run

Save the code as LineApplication.cs.
Open Visual Studio or use .NET CLI.
Compile and run the program:

dotnet new console -n LineApp
cd LineApp
# Replace Program.cs with LineApplication.cs content
dotnet run
