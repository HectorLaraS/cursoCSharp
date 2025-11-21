using System;
using System.Collections.Generic;
using System.Text;

namespace statics
{
    internal class Person
    {
        public static int count;
        private string _name;
        private int _age;

        public string Name { get; set; }
        public int Age { get; set; }
        public Person() {
            count++;
        }
        public Person(string name, int age)
        {
            this._name = name;
            this._age = _age;
            count++;
        }

        public static string GetCounts() {
            return $"se han creado {count} Personas";
        }
    }
}
