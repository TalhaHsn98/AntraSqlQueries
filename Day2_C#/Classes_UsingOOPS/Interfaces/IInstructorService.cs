using Classes_UsingOOPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_UsingOOPS.Interfaces
{
    public interface IInstructorService : IPersonService
    {
        void AssignDepartment(int instructorId, int departmentId);
        void SetAsHeadOfDepartment(int instructorId, int departmentId);
        decimal CalculateBonusSalary(int instructorId, decimal baseSalary, DateTime joinDate);
        int CalculateYearsOfExperience(DateTime joinDate);
    }
}
