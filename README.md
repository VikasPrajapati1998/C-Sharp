# C#

## Introduction
- C# is a modern, general-purpose, object-oriented programming language developed by Miscrosoft and approved by European Computer Manufactures Association (ECMA) and Internation Standards Organization (ISO).
- C# is designed by `Anders Hejlsberg` and his team during the development of `.Net` Framework.
- Key Characteristics of C#
    - Object-Oriented
    - Type-Safe
    - Cross-Paltform
    - Scalable & Maintainable
    - Rich Library Support
    - High Performance
- Strong Programming Features
    - Boolean Conditions
    - Automatic Garbage Collection
    - Standard Library
    - Assembly Versioning
    - Properties and Events
    - Delegates and Events Management
    - Easy-to-use Generics
    - Indexers
    - Conditional Compilation
    - Simple Multithreading
    - LINQ and Lambda Expressions
    - Integration with Windows

## C# Environment Setup

### **Step 1: Installing .NET SDK**
- Download the latest .Net SDK from official .NET website.
- `https://dotnet.microsoft.com/en-us/download`
- cmd: `dotnet --version`
```
C:\Users\HP\Desktop\STUDY\C-Sharp>dotnet --version
10.0.101
```
### **Step 2: Code Editor**
- Visual Studio

### **Step 3: Setting Up C# in Visual Studio Code**
```
Open VS Code
Go to Extensions
Search for "C#" and install the *C# Dev Kit* extenstion
```

### **Step 4: Writing First C# Program**
- **Creating a New C# Project**
    - `mkdir MyCSharpApp && cd MyCSharpApp`
- **Create a new C# console application:**
    - `dotnet new console -o MyCSharpApp`
    - `cd MyCSharpApp`

### **Step 5: Running Your First C# Program**
- Open the `Program.cs` file in VS Code and add the following code.
```
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, C# World!");
    }
}
```
- Run the program. cmd: `dotnet run`
- Expected Output. cmd: `Hello, C# World!`

## Setting Up C# for Advanced Development
- 1. Installing NuGet Packages
    - cmd: `dotnet add package Newtonsoft.Json`
- 2. Debugging C# Code
    - Press F5 in Visual Studio.

