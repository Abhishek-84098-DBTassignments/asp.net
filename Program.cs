namespace StudentArray;

    public struct Student
{
    public string Name;
    public bool Gender;
    public int Age;
    public int Std;
    public char Div;
    public double Marks;
}



internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of students: ");
        int size = Convert.ToInt32(Console.ReadLine());

        Student[] students = CreateArray(5);
        AcceptInfo(students);
        PrintInfo(students);
        Student[] reversedStudents = ReverseArray(students);
        Console.WriteLine("\nReversed Student Information:");
        PrintInfo(reversedStudents);



    }
    public static Student[] CreateArray(int size)
    {
        Student[] students = new Student[size];
        return students;
    }
    public static void AcceptInfo(Student[] students)
    {
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"\nEnter details for student {i + 1}:");
            Console.Write("Name: ");
            students[i].Name = Console.ReadLine();

            Console.Write("Gender (true for male, false for female): ");
            students[i].Gender = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Age: ");
            students[i].Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Standard: ");
            students[i].Std = Convert.ToInt32(Console.ReadLine());

            Console.Write("Division: ");
            students[i].Div = Convert.ToChar(Console.ReadLine());

            Console.Write("Marks: ");
            students[i].Marks = Convert.ToDouble(Console.ReadLine());
        }
    }
    public static void PrintInfo(Student[] students)
    {
        Console.WriteLine("\nStudent Information:");
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"\nDetails of student {i + 1}:");
            Console.WriteLine($"Name: {students[i].Name}");
            Console.WriteLine($"Gender: {(students[i].Gender ? "Male" : "Female")}");
            Console.WriteLine($"Age: {students[i].Age}");
            Console.WriteLine($"Standard: {students[i].Std}");
            Console.WriteLine($"Division: {students[i].Div}");
            Console.WriteLine($"Marks: {students[i].Marks}");
        }
    }
    public static Student[] ReverseArray(Student[] students)
    {
        Student[] reversedArray = new Student[students.Length];

        for (int i = 0, j = students.Length - 1; i < students.Length; i++, j--)
        {
            reversedArray[i] = students[j];
        }
        return reversedArray;
    }
  }

