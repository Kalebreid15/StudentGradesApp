using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesApp
{
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


