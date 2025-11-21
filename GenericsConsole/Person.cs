using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsConsole
{
    internal class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Person() { }
        public Person(string name, int id) { Name = name; Id = id; }

        public override string ToString() { return $"Person:{this.Name}, ID:{this.Id}"; }
    }
}
