using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Employee
{
    class Employee
    {
        public String Name;
        public String Type;
        public int    Id;

        public Employee(){}

        public Employee(String name, String type, int id)
        {
            Name = name;
            Type = type;
            Id   = id;
        }
    }
}
