using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Employee
{
    class EmployeeRepository
    {
        private Dictionary<int,Employee> list = new Dictionary<int,Employee>();
        private int                      id   = 0;

        public void Clear()
        {
            list.Clear();        
        }
        
        public int NextId()
        {
            return ++id;
        }

        public int CountEmployees()
        {
            return list.Count();
        }

        public Employee CreateEmployee(String name, String type)
        {
            Employee employee = new Employee(name, type, NextId());

            list.Add(employee.Id, employee);

            return list[employee.Id];  
        }

        public Employee LoadEmployee(int id)
        {
            return list[id];
        }

        public void SaveEmployee(Employee e)
        {
            list[e.Id] = e;
        }

        public List<Employee> FindAllEmployees()
        {
            List<Employee> allEmployees = new List<Employee>();

            foreach(var employee in list)
            {
                allEmployees.Add(employee.Value);
            }

            return allEmployees;
        }
    }
}
