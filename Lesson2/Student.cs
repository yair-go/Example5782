﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson1;

namespace Lesson2
{
    public class Student : Person
    {
        private int grade;


        public Student(int id) : base(id)
        {

        }

        public int Grade { get => grade; set => grade = value; }
        public DateTime RegDate { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Grade {grade}";
        }
    }
}
