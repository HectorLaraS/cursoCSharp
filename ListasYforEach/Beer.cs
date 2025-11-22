using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using HX = ListasYforEach.HXHelpFunctions;




namespace ListasYforEach
{
    internal class Beer
    {
        private string _name;
        private string _brand;
        private decimal _price;
        

        public string Name {
            get { return this._name; }
            set { this._name = value; }
        }
        public string Brand { get { return this._brand; } set { this._brand = value;  } }
        public decimal price { 
            get { return this._price;  } 
            set {
                if (value > 18)
                {
                    this._price = value;
                }
                else this._price = 18.0m;
            } 
        }

        public Beer() { }
        public Beer(string name, string brand) { 
            this._name = name;
            this._brand = brand;
        }
        public Beer(string name, string brand, decimal price) { 
            this._name = name;
            this._brand = brand;
            this._price = price;
        }

        public override string ToString()
        {
            return $"Name:{this._name}, Brand:{this._brand}";
        }

        public string ToJSON() { 
            return JsonSerializer.Serialize(this, HX.options);
        }
    }
}
