using System;
using System.Collections.Generic;

namespace StudentGradesApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Step 4. Create a list of student objects
            List<Student> students = new List<Student>();

            // Step 5. Create 4 student objects
            Student student1 = new Student
            {
                Name = "John Doe",
                ID = 12345
            };

            Student student2 = new Student
            {
                Name = "Jane Smith",
                ID = 67890
            };

            Student student3 = new Student
            {
                Name = "Alice Johnson",
                ID = 11223
            };

            Student student4 = new Student
            {
                Name = "Bob Brown",
                ID = 44556
            };

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);

            student1.AddGrade(94.3);
            student1.AddGrade(90.0, 78.9, 95.4);

            student2.AddGrade(88.5);
            student2.AddGrade(82.0, 91.2);

            student3.AddGrade(75.0);
            student3.AddGrade(80.5, 85.0, 90.0);

            student4.AddGrade(92.0);
            student4.AddGrade(89.5, 87.0, 93.0);

            foreach (var student in students)
            {
                // Print each student's info and grades
                Console.WriteLine($"Student: {student.Name} (ID: {student.ID})");
                Console.WriteLine("Grades: " + string.Join(", ", student.Grades));
                Console.WriteLine($"Average Grade: {student.CalculateAverageGrade():F2}");
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}

