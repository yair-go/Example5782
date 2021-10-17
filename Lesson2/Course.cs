using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public struct Course
    {
        #region Properties
        public int Id { get; init; }
        public String Name { get; set; }

        #endregion

        public override string ToString()
        {
            return $"ID: {Id} Name: {Name}";
        }
    }
}
