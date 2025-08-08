using Classes_UsingOOPS.Interfaces;
using Classes_UsingOOPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_UsingOOPS.Classes
{
    public class InstructorService : PersonService, IInstructorService
    {
        private Dictionary<int, int> _instructorDepartments = new();
        private Dictionary<int, int> _departmentHeads = new();

        public void AssignDepartment(int instructorId, int departmentId)
        {
            _instructorDepartments[instructorId] = departmentId;
        }

        public void SetAsHeadOfDepartment(int instructorId, int departmentId)
        {
            _departmentHeads[departmentId] = instructorId;
        }

        public decimal CalculateBonusSalary(int instructorId, decimal baseSalary, DateTime joinDate)
        {
            int years = CalculateYearsOfExperience(joinDate);
            decimal bonus = baseSalary * (0.05m * years);
            return CalculateSalary(baseSalary + bonus);
        }

        public int CalculateYearsOfExperience(DateTime joinDate)
        {
            return DateTime.Now.Year - joinDate.Year;
        }
    }
}
