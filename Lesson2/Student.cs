using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson1;

namespace Lesson2
{
    public class Student : Person, IComparable<Student>
    {
        private int grade;

        public Student(int id) : base(id)
        {

        }

        IEnumerable<Course> Courses { get; set; }

        public int Grade { get => grade; set => grade = value; }
        public DateTime RegDate { get; set; }

        public int CompareTo(Student? other)
        {
            return this.Grade.CompareTo(other.Grade);
        }

        public override string ToString()
        {
            return base.ToString() + $", Grade {grade}";
        }

       
    }
}
