using System;

record Student(string FirstName, string LastName, double GPA, string Major, int AttemptedHours, int CompletedHours);

class Program
{
    static void Main()
    {
        // Creating three Student records with manually changed names and numbers
        var record1 = new Student("Alice", "Wonder", 3.9, "Computer Science", 95, 85);
        var record2 = new Student("Bob", "Marvel", 3.6, "Mathematics", 105, 92);
        var record3 = new Student("Charlie", "Power", 3.4, "Physics", 88, 70);

        // Printing information about each student
        PrintStudentInfo(record1);
        PrintStudentInfo(record2);
        PrintStudentInfo(record3);

        // Attempting to change values for one of the records
        // student1.GPA = 3.7; // this errors cause the value is immutable

        // creating new record is allowed 
        var modifiedStudent1 = record1 with { GPA = 3.1 };
        PrintStudentInfo(modifiedStudent1);
    }

    static void PrintStudentInfo(Student student)
    {
        Console.WriteLine($"Student: {student.FirstName} {student.LastName}");
        Console.WriteLine($"GPA: {student.GPA}");
        Console.WriteLine($"Major: {student.Major}");
        Console.WriteLine($"Attempted Hours: {student.AttemptedHours}");
        Console.WriteLine($"Completed Hours: {student.CompletedHours}");
        Console.WriteLine();
    }
}