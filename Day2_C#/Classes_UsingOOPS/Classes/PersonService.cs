using Classes_UsingOOPS.Interfaces;
using Classes_UsingOOPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_UsingOOPS.Classes
{
    public class PersonService : IPersonService
    {
        protected Dictionary<int, List<string>> _addresses = new Dictionary<int, List<string>>();

        public int CalculateAge(DateTime dob)
        {
            return DateTime.Now.Year - dob.Year;
        }

        public decimal CalculateSalary(decimal baseSalary)
        {
            if (baseSalary < 0)
                throw new ArgumentException("Salary cannot be negative");
            return baseSalary;
        }

        public void AddAddress(int personId, string address)
        {
            if (!_addresses.ContainsKey(personId))
                _addresses[personId] = new List<string>();

            _addresses[personId].Add(address);
        }

        public List<string> GetAddresses(int personId)
        {
            return _addresses.ContainsKey(personId) ? new List<string>(_addresses[personId]) : new List<string>();
        }
    }

}
