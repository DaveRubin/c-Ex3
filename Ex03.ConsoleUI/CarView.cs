using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    internal class CarView
    {
        private static string k_CarViewTemplate = @"Car color : {0}
Number of doors: {1}";

        public static string GetCarView(Car i_Car)
        {
            return string.Format(k_CarViewTemplate, i_Car.r_Color, i_Car.r_DoorsCount);
        }
    }
}
