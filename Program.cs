using System;
using System.Security.Cryptography.X509Certificates;

namespace StudentStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Abhi", true, 18, 12, 'D', 85.5);
            student.ToString();
            student.AcceptDetails();
            student.PrintDetails();

        }
    }
    public class Student
    {
        private string _Name;
        private bool _Gender;
        private int _Age;
        private int _Std;
        private char _Div;
        private double _Marks;

        public Student()
        {
            
        }

        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            Name = name;
            Gender = gender;
            Age = age;
            Std = std;
            Div = div;
            Marks = marks;
        }

        public string Name { get => _Name; set => _Name = value; }
        public bool Gender { get => _Gender; set => _Gender = value; }
        public int Age { get => _Age; set => _Age = value; }
        public int Std { get => _Std; set => _Std = value; }
        public char Div { get => _Div; set => _Div = value; }
        public double Marks { get => _Marks; set => _Marks = value; }

        public override string? ToString()
        {
            return base.ToString();
        }
        public void AcceptDetails()
        {
            Console.WriteLine("Enter student details:");
            Console.Write("Name: ");
            Name = Console.ReadLine();

            Console.Write("Gender (true for male, false for female): ");
            Gender = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Age: ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Standard: ");
            Std = Convert.ToInt32(Console.ReadLine());

            Console.Write("Division: ");
            Div = Convert.ToChar(Console.ReadLine());

            Console.Write("Marks: ");
            Marks = Convert.ToDouble(Console.ReadLine());
        }
        public void PrintDetails()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Gender: {(Gender ? "Male" : "Female")}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Standard: {Std}");
            Console.WriteLine($"Division: {Div}");
            Console.WriteLine($"Marks: {Marks}");
        }

    }
}
