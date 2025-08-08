using Classes_UsingOOPS.Interfaces;
using Classes_UsingOOPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_UsingOOPS.Classes
{
    public class CourseService : ICourseService
    {
        private List<Course> _courses = new();
        private Dictionary<int, List<Student>> _courseStudents = new();

        public void AddCourse(Course course)
        {
            _courses.Add(course);
        }

        public List<Student> GetEnrolledStudents(int courseId)
        {
            return _courseStudents.ContainsKey(courseId) ? new List<Student>(_courseStudents[courseId]) : new List<Student>();
        }
    }
}
