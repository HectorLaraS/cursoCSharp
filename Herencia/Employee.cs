using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    internal class Employee: Person
    {
        private string department;

        public string Department { 
            set; get;
        }

        public Employee() { }
        public Employee(string name, int age, string Department):base(name, age)
        { 
            this.department = Department;
        }

        public string GetInformation() {
            return $"Employee(Name:{this.name}, Age:{this.age}, Department:{this.department})";
        }


    }
}
