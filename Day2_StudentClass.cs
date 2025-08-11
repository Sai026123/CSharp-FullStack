
// Day 2 - Classes and Objects in C#
// Learning Objective: Create a class, define properties, constructors, and methods.

using System;

namespace MyLearning
{
    public class Student
    {
        // Auto-implemented properties
        public string Name { get; set; }
        public int RollNumber { get; set; }
        private int Marks;

        // Constructor
        public Student(string name, int rollNumber)
        {
            Name = name;
            RollNumber = rollNumber;
        }

        // Method to set marks
        public void SetMarks(int marks)
        {
            Marks = marks;
        }

        // Method to display student details
        public void ShowDetails()
        {
            Console.WriteLine($"Name: {Name}, Roll Number: {RollNumber}, Marks: {Marks}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an object of Student
            Student stu = new Student("Anusha", 45);

            // Setting marks
            stu.SetMarks(95);

            // Displaying details
            stu.ShowDetails();
        }
    }
}
