using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    internal class Person
    {
        private string _name;
        private string _email;  
        private string _phone;

        public string Name { get { return _name; } set { _name = value; } } 
        public string Email { get { return _email;  } set { _email = value; } } 
        public string Phone { get { return _phone;  } set { _phone = value; } }
        public Person() { } 

        public Person(string name, string email, string phone)
        {
            this._name = name;
            this._email = email;
            this._phone = phone;
        }
    }
}
