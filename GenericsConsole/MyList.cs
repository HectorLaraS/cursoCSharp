using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsConsole
{
    internal class MyList<T>
    {
        private T[] _elements;
        private int _index = 0;

        public T[] Elements {  get { return _elements; } }

        public MyList(int index) {
            this._elements = new T[index];
        }

        public void Add(T element) {
            if (this._index < this._elements.Length) {
                this._elements[this._index] = element;
                this._index++;
            } else {
                Console.WriteLine("fail");
                    }
        }

        public void ShowElements() {
            for (int i = 0; i < this._elements.Length; i++)
            {
                Console.WriteLine(this._elements[i]);
            }
        }

        public T GetElement(int userIndex) {
            if (userIndex <= this._index && userIndex >= 0)
            {
                return this._elements[userIndex];
            }
            else return default(T);
        }

    }
}
