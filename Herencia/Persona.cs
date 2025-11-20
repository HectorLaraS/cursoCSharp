using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    internal class Persona
    {
        protected string _nombre;
        protected int _age;

        public Persona() { }

        public Persona(string nombre, int age) { 
            this._nombre = nombre;
            this._age = age;
        }

        public virtual string GetInformation() {
            return $"{this._nombre} {this._age}";
        }

    }
}
