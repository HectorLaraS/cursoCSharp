using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    internal class Doctor: Persona
    {
        private string _speciality;
        public string Speciality {
            get { return this._speciality; }
            set { this._speciality = value; }
        }

        public Doctor(string nombre, int age, string speciality):base(nombre, age) {
            this._speciality = speciality;
        }

        public override string GetInformation()
        {
            return $"{base.GetInformation()} {this.Speciality}";
        }
    }
}
