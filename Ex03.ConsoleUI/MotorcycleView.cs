using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    using Ex03.GarageLogic;

    internal class MotorcycleView
    {
        private static string k_MotorcycleViewTemplate = @"License type : {0}
Engine volume (cc): {1}";

        public static string GetMotorCycleView(Motorcycle i_Motorcycle)
        {
            return string.Format(k_MotorcycleViewTemplate, i_Motorcycle.r_LicenseType, i_Motorcycle.r_EngineVolume);
        }
    }
}
