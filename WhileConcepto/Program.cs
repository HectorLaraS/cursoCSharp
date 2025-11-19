using System;

int i = 0;
int j = 0;  


while (i < 10) {
    Console.WriteLine($"Iteracion de i: {i}");
    i ++;
}

Console.WriteLine("-------------------");

while (j < 20) {
    if (j > 10)
        break;
    Console.WriteLine($"Iteracion de j: {j}");
    j ++;
}

Console.WriteLine("-------------------");

string[] amigos = new string[7];
amigos[0] = "Jazmin";
amigos[1] = "Gabon";
amigos[2] = "Jorge";
amigos[3] = "Carlos";
amigos[4] = "Erick";
amigos[5] = "Hector";
amigos[1] = "Arely";

int index = 0;
Console.WriteLine(amigos.Length);
while (index < amigos.Length) {
    Console.WriteLine(amigos[index]);
    index ++;
}

DateTime fechahoy = DateTime.Now;
Console.WriteLine(fechahoy);
Console.WriteLine(fechahoy.Date.ToString("yyyy-MM-dd"));