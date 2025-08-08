using Classes_UsingOOPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_UsingOOPS.Interfaces
{
    public interface ICourseService
    {
        void AddCourse(Course course);
        List<Student> GetEnrolledStudents(int courseId);
    }
}
