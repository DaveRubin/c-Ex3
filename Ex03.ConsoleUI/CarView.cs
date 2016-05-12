using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    internal class CarView
    {

        public static string GetCarView(Car i_Car)
        {
            return string.Format(VehicleViewTextTemplates.k_CarViewTemplate, i_Car.r_Color, i_Car.r_DoorsCount);
        }
    }
}
