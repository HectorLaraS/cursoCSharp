using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    internal interface IDeveloper
    {
        public string Proyecto { get; set; }
        public string[] Tecnologias { get; set; }

        public string[] GetTecnologias();


    }
}
