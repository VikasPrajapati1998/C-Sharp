using System;

namespace BasicsDemo
{
    // Enum should be declared outside methods
    enum JobLevel
    {
        Intern,
        Junior,
        Mid,
        Senior,
        Manager
    }

    struct Employee
    {
        public int ID;
        public string Name;
        public double Salary;
    }

    class Program
    {
        static void Main(string[] args)
        {
            CaseSensitivityDemo();
            CurlyBracesDemo();
            ConditionalStatementsDemo();
            DataTypesDemo();
        }

        // Demonstrates case sensitivity in C#
        static void CaseSensitivityDemo()
        {
            int Age = 30;
            int age = 25;

            Console.WriteLine("Case Sensitivity:");
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("age: " + age);
            Console.WriteLine();
        }

        // Demonstrates use of curly braces
        static void CurlyBracesDemo()
        {
            int x = 7;

            Console.WriteLine("Curly Braces Demo:");
            if (x > 5)
            {
                Console.WriteLine("x is greater than 5");
            }
            Console.WriteLine();
        }

        // Demonstrates conditional statements
        static void ConditionalStatementsDemo()
        {
            int age = 18;

            Console.WriteLine("Conditional Statements:");
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }
            Console.WriteLine();
        }

        // Demonstrates different data types
        static void DataTypesDemo()
        {
            // Basic data types
            string studentName = "Sumit";
            int studentAge = 20;
            double score = 85.5;
            char grade = 'A';
            bool isActive = true;

            Console.WriteLine("Student Details:");
            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Age: " + studentAge);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Is Active: " + isActive);
            Console.WriteLine();

            // Numeric data types
            int customerId = 234;
            long salary = 23412341234L;
            byte experience = 10;

            float gap = 3.45f;
            double distance = 232324.34;
            decimal accountBalance = 2343234.234m;

            bool isGraduate = false;
            char section = 'B';

            JobLevel jobLevel = JobLevel.Junior;

            Console.WriteLine("Employee Details:");
            Console.WriteLine("Customer ID: " + customerId);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Experience: " + experience);
            Console.WriteLine("Gap: " + gap);
            Console.WriteLine("Distance: " + distance);
            Console.WriteLine("Account Balance: " + accountBalance);
            Console.WriteLine("Is Graduate: " + isGraduate);
            Console.WriteLine("Section: " + section);
            Console.WriteLine("Job Level: " + jobLevel);

            // Struct
            Employee emp;
            emp.ID = 101;
            emp.Name = "Zoya";
            emp.Salary = 60000.50;

            Console.WriteLine("Employee ID: " + emp.ID);
            Console.WriteLine("Employee Name: " + emp.Name);
            Console.WriteLine("Employee Salary: $" + emp.Salary);

            // Object
            object obj = 10001;
            Console.WriteLine("Student ID: " + obj);

            obj = "Sumit Verma";
            Console.WriteLine("Student Name: " + obj);

            // Dynamic
            dynamic value = 10;
            Console.WriteLine("Dynamic Value: " + value);
            
            value = "Hello World";
            Console.WriteLine("Dynamic now contain: " + value);
        }
    }
}
