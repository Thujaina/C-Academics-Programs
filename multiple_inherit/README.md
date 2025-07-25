# Multiple Inheritance in C# using Interface

This project demonstrates how multiple inheritance can be achieved in C# using interfaces. Since C# does **not support multiple inheritance** of classes, interfaces are used to simulate multiple inheritance behavior.

## 🧠 Key Concepts

- **Class Inheritance:** The `Rectangle` class inherits from `Shape`.
- **Interface Implementation:** The `Rectangle` class also implements the `PaintCost` interface.
- **Method Overriding and Access Modifiers:** Methods and variables are used with appropriate access levels (e.g., `protected`).

---

## 📂 File Structure

- `mult.cs` — Contains the complete implementation of the classes and interface.

---

## 🧾 Program Description

The program defines:
1. `Shape` class with `setWidth` and `setHeight` methods and protected members `width` and `height`.
2. `PaintCost` interface with a method `getCost(int area)`.
3. `Rectangle` class that **inherits from `Shape` and implements `PaintCost`**.
4. `RectangleTester` class to create a `Rectangle` object, set dimensions, calculate area, and print it.

---

## 📌 Code Output

The output will display the total area of the rectangle:

Total area: 35


*(When width = 5 and height = 7)*

---

## ▶️ How to Run

1. Save the file as `mult.cs`.
2. Compile the program:
   ```bash
   csc mult.cs

Run the program:
mono mult.exe   # on macOS/Linux

or

mult            # on Windows
