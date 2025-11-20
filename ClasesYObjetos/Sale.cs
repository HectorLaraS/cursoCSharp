using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesYObjetos
{
    internal class Sale
    {
        private int total;
        DateTime date;

        public int Total {
            get {
                return this.total;
            }
            set {
                if (value < 0)
                    value = 0;
                this.total = value;
            }
        }

        public string Date {
            get { 
                return this.date.ToLongDateString();
            }
        }

        public Sale(int total, DateTime date) {
            this.total = total;
            this.date = date;
        }
        public Sale() { }

        public void show() {
            Console.WriteLine("Soy una venta");
        }

        public string GetInformation() {
            return $"Total:{this.total}, date:{date.ToLongDateString()}";
        }
    }
}
