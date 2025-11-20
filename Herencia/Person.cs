using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    internal class Person
    {
        protected string name;
        protected int age;

        public string Name {
            get { 
                return name;
            }
            set { 
                this.name = value;
            }
        }

        public int Age {
            get {
                return this.age;
            }
        }

        public Person() { }

        public Person(string name, int age) {
            this.name = name;
            this.age = age;
        }


    }
}
