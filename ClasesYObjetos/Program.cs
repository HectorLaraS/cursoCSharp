using ClasesYObjetos;
DateTime today = DateTime.Now;
Sale venta_1 = new Sale(16, today);
venta_1.show();
Console.WriteLine(venta_1.GetInformation());

venta_1.Total = -10;
Console.WriteLine(venta_1.GetInformation());
Console.WriteLine("----------------------------");
Console.WriteLine(venta_1.Date);