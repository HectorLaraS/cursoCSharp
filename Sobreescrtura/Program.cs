using Sobreescrtura;

SaleWithTax new_sale = new SaleWithTax(10, 1.16m);
new_sale.Add(10m);
new_sale.Add(10.23m);
Console.WriteLine(new_sale.GetTotal());