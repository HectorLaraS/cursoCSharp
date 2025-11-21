using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Interfaces
{
    internal class Desarrollador: Person, IDeveloper, IEmpleado
    {
        public string departamento { get; set; }
        public string Proyecto { get; set; }
        public string[] Tecnologias { get; set; }

        public Desarrollador() { }
        public Desarrollador(string name, string email, string phone):base(name, email, phone) {}

        public string[] GetTecnologias() {
            return this.Tecnologias;
        }

    }
}
