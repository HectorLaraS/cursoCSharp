using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Sobrecarga
{
    internal class Math
    {
        public static int Sum(int number_1, int number_2) {
            return number_1 + number_2;
        }

        public static int Sum(string number_1, string number_2)
        {
            return int.Parse(number_1) + int.Parse(number_2);
        }

        public static int Sum(int[] numbers) { 
            int result = 0;
            for (int i = 0; i < numbers.Length; i++) { 
                result += numbers[i];   
            }
            return result;
        }
    }
}
