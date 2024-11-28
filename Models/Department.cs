using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDLab5_6.Models
{
    internal class Department
    {
        public string Name { get; private set; }
        private List<Employee> _employees;
        public Department(string name, params Employee[] employees)
        {
            Name = name;
            if(employees == null || employees.Length == 0) 
            {
                throw new ArgumentException();
            }
            _employees = new List<Employee>(employees.Length);
            _employees.AddRange(employees);
        }
    }
}
