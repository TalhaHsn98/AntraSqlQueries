using Classes_UsingOOPS.Interfaces;
using Classes_UsingOOPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_UsingOOPS.Classes
{
    public class DepartmentService : IDepartmentService
    {
        private List<Department> _departments = new();
        private Dictionary<int, List<Course>> _departmentCourses = new();

        public void AddDepartment(Department department)
        {
            _departments.Add(department);
        }

        public void AssignHead(int departmentId, int instructorId)
        {
            var dept = _departments.FirstOrDefault(d => d.DepartmentId == departmentId);
            if (dept != null)
                dept.HeadInstructorId = instructorId;
        }

        public List<Course> GetDepartmentCourses(int departmentId)
        {
            return _departmentCourses.ContainsKey(departmentId) ? new List<Course>(_departmentCourses[departmentId]) : new List<Course>();
        }
    }
}
