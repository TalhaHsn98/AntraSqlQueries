using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_UsingOOPS.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; } 
    }
}
