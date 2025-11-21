using System;
using System.Collections.Generic;
using System.Text;

namespace FormatoJSON
{
    internal class Beer
    {
        public string Name { get; set; }
        public string Brand {  get; set; }

        public Beer() { }

        public override string ToString()
        {
            return $"Beer:{this.Name}, Brand:{this.Brand}";
        }
    }
}
