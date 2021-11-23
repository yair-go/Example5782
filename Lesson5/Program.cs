using Lesson2;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            double ave = students.Average(student => student.Grade);
            foreach (var student in students)
            {

            }
        
        }
    }
}
