using Classes_UsingOOPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_UsingOOPS.Interfaces
{
    public interface IStudentService : IPersonService
    {
        void EnrollInCourse(int studentId, int courseId);
        void AssignGrade(int studentId, int courseId, char grade);
        double CalculateGPA(int studentId);
        List<int> GetEnrolledCourses(int studentId);
    }

}
