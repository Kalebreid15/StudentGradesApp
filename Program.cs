using System.Collections.Generic;

namespace StudentGradesApp;

public class Student
{
    static void Main(string[] args)
    {
        Student student = new Student
        {
            Name = "John Doe",
            ID = 12345
        };

        student.AddGrade(90.5, 85.5, 79.8);

        Console.WriteLine($"Student: {student.Name} (ID: {student.ID})");
        Console.WriteLine("Grades: " + string.Join(", ", student.Grades));

    }

    //Student's name
    public required string Name { get; set; }

    // Student's unique ID
    public int ID { get; set; }

    //List to hold student's grades
    public List<double> Grades { get; set; } = new List<double>();

    // Method to add a grade to the Grades list
    public void AddGrade(double grade)
    {
        Grades.Add(grade);
    }

    public void AddGrade(params double[] grades)
    {
        {
            Grades.AddRange(grades); // Add all provided grades to the list
        }
    }
}