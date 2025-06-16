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

            // Add grades to student1 for testing
            student1.AddGrade(90.5, 85.0, 78.3);

            // Print student1's info and grades
            Console.WriteLine($"Student: {student1.Name} (ID: {student1.ID})");
            Console.WriteLine("Grades: " + string.Join(", ", student1.Grades));
            Console.WriteLine($"Average Grade: {student1.CalculateAverageGrade():F2}");
        }
    }

    public class Student
    {
        public required string Name { get; set; } // Student's name
        public int ID { get; set; } // Student's ID
        public List<double> Grades { get; set; } = new List<double>(); // Grades list

        // Add one or more grades using params
        public void AddGrade(params double[] grades)
        {
            Grades.AddRange(grades);
        }

        // Calculate and return the average grade
        public double CalculateAverageGrade()
        {
            if (Grades.Count == 0)
                return 0;

            double sum = 0;
            foreach (var grade in Grades)
            {
                sum += grade;
            }

            return sum / Grades.Count;
        }
    }
}
