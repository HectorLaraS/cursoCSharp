int op = 7;

switch (op) {
    case 1:
        Console.WriteLine("Seleccionaste 1");
        break;
    case 2:
        Console.WriteLine("Seleccionaste 2");
        break;
    case 3:
    case 4:
        Console.WriteLine("seleccionaste caso 3 3o 4");
        break;
    case > 100:
    case < 0:
        Console.WriteLine("valor fuera de rango");
        break;
    case > 4 and < 10:
        Console.WriteLine("Selecciono una opcion entre 4 y 10");
        break;
    default:
        Console.WriteLine("Caso no valido");
        break;
}