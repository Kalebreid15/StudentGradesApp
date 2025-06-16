using System.Collections.Generic;
using System.Security;

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
        List<Student> students = new List<Student>();
        

        student.AddGrade();

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

    public double CalculateAverageGrade()
    {
        if (Grades.Count == 0)
        {
            return 0; // Return 0 if no grades exist
        }

        double sum = 0;
        foreach (var grade in Grades)
        {
            sum += grade;
        }

        return sum / Grades.Count; // Return the average grade
    }



}