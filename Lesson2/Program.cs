using System;

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

            Course course = new Course() { Id = 153007, Name = "C#" };
            course.Name = "dotnet";
            Console.WriteLine(course);
        }
    }
}
