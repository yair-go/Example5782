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
        }
    }
}
