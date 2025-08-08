using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_UsingOOPS.Models
{
    public class Instructor : Person
    {
        public int InstructorId { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; } 
    }
}
