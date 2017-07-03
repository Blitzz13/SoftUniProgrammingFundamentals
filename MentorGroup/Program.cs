using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string[] tokens = Console.ReadLine().Split(' ', ',').ToArray();

                string name = tokens[0];
                string breakingPoint = string.Join(" ", tokens);
                if (breakingPoint == "end of dates")
                {
                    break;
                }
                var date = tokens.Skip(1).ToList();

                List<DateTime> dates = date.Select(d => DateTime.ParseExact(d, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList();
                if (students.Select(a => a.Name).Contains(name))
                {
                    for (int i = 0; i < students.Count; i++)
                    {
                        if (students[i].Name == name)
                        {
                            students[i].DatesAttended.AddRange(dates);
                        }
                    }
                }
                else
                {
                    Student student = new Student()
                    {
                        Name = name,
                        DatesAttended = dates,
                        Comments = new List<string>()

                    };
                    students.Add(student);
                }

            }



            while (true)
            {
                string[] tokens = Console.ReadLine().Split('-', ' ').ToArray();

                string breakingPoint = string.Join(" ", tokens);
                if (breakingPoint == "end of comments")
                {
                    break;
                }

                string name = tokens[0];
                string[] commentArr = tokens.Skip(1).ToArray();
                string commentStr = string.Join(" ", commentArr);
                foreach (var user in students)
                {
                    if (user.Name == name)
                    {
                        user.Comments.Add(commentStr);
                    }
                }
            }

            students = students.OrderBy(a => a.Name).ToList();
            foreach (var studentt in students)
            {
                Console.WriteLine(studentt.Name);
                Console.WriteLine("Comments:");
                foreach (var comment in studentt.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                var orderedDates = studentt.DatesAttended.OrderBy(a => a).ToList();
                foreach (var date in orderedDates)
                {
                    Console.WriteLine($"-- {date.ToString(@"dd\/MM\/yyyy")}");
                }
            }


        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> DatesAttended { get; set; }
    }

}

