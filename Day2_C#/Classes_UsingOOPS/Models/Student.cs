using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_UsingOOPS.Models
{
    public class Student : Person
    {
        public int StudentId { get; set; }
        public string Major { get; set; }
        public int CreditsEarned { get; set; }
    }
}
