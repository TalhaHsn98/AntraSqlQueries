using Classes_UsingOOPS.Interfaces;
using Classes_UsingOOPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_UsingOOPS.Classes
{
    public class StudentService : PersonService, IStudentService
    {
        private Dictionary<int, List<int>> _studentCourses = new();
        private Dictionary<(int studentId, int courseId), char> _grades = new();

        public void EnrollInCourse(int studentId, int courseId)
        {
            if (!_studentCourses.ContainsKey(studentId))
                _studentCourses[studentId] = new List<int>();

            _studentCourses[studentId].Add(courseId);
        }

        public void AssignGrade(int studentId, int courseId, char grade)
        {
            _grades[(studentId, courseId)] = grade;
        }

        public double CalculateGPA(int studentId)
        {
            if (!_grades.Any(g => g.Key.studentId == studentId))
                return 0;

            Dictionary<char, double> gradePoints = new()
        {
            { 'A', 4.0 }, { 'B', 3.0 }, { 'C', 2.0 }, { 'D', 1.0 }, { 'F', 0.0 }
        };

            var studentGrades = _grades.Where(g => g.Key.studentId == studentId).Select(g => gradePoints[g.Value]);
            return studentGrades.Average();
        }

        public List<int> GetEnrolledCourses(int studentId)
        {
            return _studentCourses.ContainsKey(studentId) ? new List<int>(_studentCourses[studentId]) : new List<int>();
        }
    }
}


