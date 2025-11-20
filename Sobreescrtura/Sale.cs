using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Sobreescrtura
{
    internal class Sale
    {
        private decimal[] _amount;
        private int _n;
        private int _end;
        private decimal _total;

        public Sale(int n) {
            this._amount = new decimal[n];
            this._n = n;
            this._end = 0;
        }

        public void Add(decimal amount) {
            if (this._end < this._n) {
                this._amount[this._end] = amount;
                this._end++;
            }
        }

        public virtual decimal GetTotal() {
            decimal subtotal = 0;
            for (int i = 0; i < this._amount.Length; i++) {
                subtotal += this._amount[i];
            }
            return subtotal;    
        }
    }
}
