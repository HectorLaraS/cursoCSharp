using System;
using System.Collections.Generic;
using System.Text;

namespace Sobreescrtura
{
    internal class SaleWithTax: Sale
    {
        private decimal _tax;

        public SaleWithTax(int n, decimal invoice) : base(n) { 
            this._tax = invoice;
        }

        public override decimal GetTotal()
        {
            return base.GetTotal() * this._tax;
        }
    }
}
