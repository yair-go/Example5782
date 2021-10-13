using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public struct Course
    {
        public int Id { get; init; }
        public String Name { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} Name: {Name}";
        }
    }
}
