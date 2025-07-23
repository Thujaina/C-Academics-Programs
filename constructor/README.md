# 📌 C# Program: Line Class Using Default Constructor

## 🧾 Description
This C# program demonstrates how to use a **default constructor** within a class. The `Line` class contains a private variable `length`, and methods to set and get the value of that variable. When an object is created, the constructor prints a message, showing the concept of object initialization.

---

## 💡 Features
- Usage of **default constructor**
- Encapsulation using `private` and public methods
- Simple and beginner-friendly structure
- Console-based input/output

---

## 📁 File Structure

Compile the program:
csc LineProgram.cs
Run the compiled executable:
LineProgram.exe

--------------------------------------------------------------------------------------------------------

# LineApplication – C# Program using Parameterized Constructor

## 📄 Description

This is a simple C# console application demonstrating the concept of a **parameterized constructor**.  
The program defines a class `Line` with a private field `length` and allows setting and retrieving the length of a line using:
- a constructor with a parameter,
- a setter method (`setLength`),
- and a getter method (`getLength`).

## 🛠 Features

- Demonstrates use of **parameterized constructor**.
- Shows **encapsulation** using `private` field and public getter/setter methods.
- Uses `Console.WriteLine` for output in the console.

## 📌 How It Works

1. When the object is created with `new Line(10.0)`, the constructor initializes `length = 10.0`.
2. It displays a message:  
   `Object is being created, length = 10`
3. Then the program prints the current length.
4. After that, it updates the length to 6.0 using `setLength(6.0)` and prints it again.

## 💡 Sample Output

Object is being created, length = 10
Length of line : 10
Length of line : 6


## 🖥️ How to Run

1. Open the project in **Visual Studio** or any C# IDE.
2. Make sure the file is saved with a `.cs` extension (e.g., `LineApplication.cs`).
3. Build and run the program.
4. The console will display the messages as described.

## 📚 Concepts Covered

- Classes and Objects
- Encapsulation
- Parameterized Constructor
- Getter and Setter methods
- Console Input/Output

---

✅ Suitable for **beginners** learning object-oriented programming in C#.

