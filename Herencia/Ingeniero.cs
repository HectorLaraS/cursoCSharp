using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    internal class Ingeniero : Persona
    {
        private string _area;

        public string Area {
            get {
                return this._area;
            }
            set
            {
                if (value == null)
                {
                    value = "GO Engineer";
                }
                this._area = value;
            }
        }

        public Ingeniero(string nombre, int age, string department) : base(nombre, age) {
            this._area = department;
        }

        public override string GetInformation()
        {
            return $"{this._nombre} {this._age}, Area:{this._area}";
        }
    }
}
