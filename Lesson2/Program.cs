using System;
using System.Collections.Generic;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student(1);
            st.Name = "Shem";
            int id = st.Id;
            Console.WriteLine(st);
            Student[] students = new Student[10];
            st.RegDate = DateTime.Now;

            Random rand = new Random();
            for (int i = 0; i < students.Length; i++)
            {
                students[i].Grade = rand.Next(55, 100);
            }

            foreach (Student student in students)
            {
                student.RegDate = DateTime.Now;
            }

            Course course = new Course() { Id = 153007, Name = "C#" };
            course.Name = "dotnet";
            Console.WriteLine(course);

            List<Student> studentsList = new List<Student>();
            studentsList.Add(new Student(2));
            studentsList[0].Grade = 100;
        }
    }
}
