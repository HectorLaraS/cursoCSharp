using System;
using System.Collections.Generic;
using System.Text;

namespace SentenciasDeControl
{
    internal class HelpFunctions
    {
        public static bool isOpenRestaurant(string name, int hour = 0) {
            bool isOpen = false;
            if (name == "Lonches Pepe" && hour > 8 && hour < 23)
            {
                isOpen = true;
            }
            else if (name == "Restaurante 24hrs")
            {
                isOpen = true;
            }
            else {
                isOpen = false;
            } 
                return isOpen;
        }


    }
}
