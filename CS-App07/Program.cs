using System;

class Program
{
    static void Main()
    {
        string firstName = "Sudhir";
        string lastName = "Sharma";
        string fullName = firstName + " " + lastName;

        Console.WriteLine("Full Name: " + fullName);

        string[] students = { "Zoya", "Yashna", "Olivia", "Naomi" };
        
        Console.WriteLine("Student List:");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }
}
