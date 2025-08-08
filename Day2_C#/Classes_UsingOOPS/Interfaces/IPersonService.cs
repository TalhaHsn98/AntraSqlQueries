using Classes_UsingOOPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_UsingOOPS.Interfaces
{
    public interface IPersonService
    {
        int CalculateAge(DateTime dateOfBirth);
        decimal CalculateSalary(decimal baseSalary); 
        void AddAddress(int personId, string address);
        List<string> GetAddresses(int personId);
    }
}
