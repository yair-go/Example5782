﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class Person
    {
        private int id;
        
        public Person(int id)
        {
            this.id = id;
        }

        public int Id { get =>  id; }
        public string Name { get ; set; }

        public override string ToString()
        {
            return $"ID: {id}, Name: {Name}";
        }
    }
}