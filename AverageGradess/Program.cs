using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGradess
{

    class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }
        public double AverageGrade => this.Grades.Average();

    }
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            int studentsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentsCount; i++)
            {

                var tokens = Console.ReadLine().Split();

                string name = tokens.First();
                var grades = tokens.Skip(1).Select(double.Parse).ToArray();
                var student = new Student()
                {
                    Name = name,
                    Grades = grades
                };

                students.Add(student);
            }
            students = students.Where(a => a.AverageGrade >= 5.00).OrderBy(a => a.Name).ThenByDescending(a => a.AverageGrade).ToList();
            foreach (var stud in students)
            {
                Console.WriteLine($"{stud.Name} -> {stud.AverageGrade:F2}");
            }
            

        }
    }
}
