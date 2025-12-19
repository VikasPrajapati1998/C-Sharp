using System;

namespace School
{
    class Student
    {
        public string Name = "Arjun Prajapati";
        public int Age = 28;
        public void DisplayStudentInfo()
        {
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Student Age: " + Age);
        }
    }

    class Program
    {
        static void Main()
        {
            Student student1 = new Student();
            student1.Name = "Alice";
            student1.Age = 14;

            student1.DisplayStudentInfo();
        }
    }
}
