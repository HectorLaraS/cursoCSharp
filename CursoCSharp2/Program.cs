using CursoCSharp2;
using hf = CursoCSharp2.HelpFunctions;

int age = 32;
string name = "Hector Lara";
bool isDeveloper = true;
bool isAdmin = true;
decimal salary = 50000.00m;

string saludar(string name) {
    return $"Hola {name}";
}

double calcularIva(double price, int impuestos) {
    double result = 0;
    result = (price * impuestos) / 100;
    return result;

}

Console.WriteLine($"Ing: {name}, age:{age}");

Console.WriteLine(saludar("Hector Lara"));
double total = 100;
int impuesto = 16;
Console.WriteLine($"el total={total}, los impuestos({impuesto})% a pagar={calcularIva(total,impuesto)}");

hf.imprimir("Hector Lara");