using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos
{
    internal class Person
    {
        private string name { get; set; }
        private int age { get; set; }

        public Person() { }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string ToString() {
            return $"Person(name:{this.name}, age:{this.age})";
        }
    }
}
