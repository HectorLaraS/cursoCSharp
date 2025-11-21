string myCadena = "     1,Hector,Lara,Developer   ";
Console.WriteLine(myCadena);
Console.WriteLine(myCadena.Trim());
string[] elementos = myCadena.Trim().Split(',');

for (int i = 0; i < elementos.Length; i++) {
    Console.WriteLine(elementos[i]);
}