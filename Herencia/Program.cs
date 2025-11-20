using System;
using System.Linq.Expressions;
using Herencia;


Employee empleado = new Employee("Hector", 32, "Information Service");
Console.WriteLine(empleado.GetInformation());

Ingeniero ingeniero_1 = new Ingeniero("Hector", 32, "Desarrollo");
Console.WriteLine(ingeniero_1.GetInformation());