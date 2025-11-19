using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp2
{
    public class HelpFunctions
    {
        public static void imprimir(string nombre) {
            Console.WriteLine($"Hola {nombre}");
        }

        public static string[] mySplit(string linea) {
            return linea.Split(",");
        }

        public static double sumar(double numeroUno, double numeroDos) {
            return numeroUno + numeroDos;
        }
    }
}
